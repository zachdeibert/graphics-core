using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    class ImplementationGenerator : IGenerator {
        public string[] Imports => new [] {
            "System",
            "System.Linq",
            "System.Runtime.InteropServices"
        };

        public string FileName => "../Natives/OpenGL.cs";

        public string Namespace => "Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop";

        void ImplementDoubleArrayMethod(StringBuilder code, List<string> errors, CommandBinding binding, int i, string indent, string paramName, string arrayType, ParameterBinding param) {
            code.AppendFormat("{0}IntPtr ptr_{1} = Marshal.AllocHGlobal(@{1}.Length * sizeof(void *));", indent, paramName);
            code.AppendLine();
            code.AppendFormat("{0}try {1}", indent, '{');
            code.AppendLine();
            code.AppendFormat("{0}    {4}ConvertDoubleArray_{1}(ptr_{2}, @{2}, (void **) ptr_{2}.ToPointer(), 0, __fixedLocals => {3}",
                    indent,
                    arrayType,
                    paramName,
                    '{',
                    binding.ReturnCSType.ReturnType == "void" ? "" : "return ");
            code.AppendLine();
            param.Name = string.Format("({0} **) ptr_{1}.ToPointer()", arrayType, paramName);
            List<string> fixedLocals = new List<string>();
            for (int j = 0, k = 0; j < i; ++j) {
                if (binding.Parameters[j].CSType.ParameterType.EndsWith("[]")) {
                    fixedLocals.Add(binding.Parameters[j].Name);
                    binding.Parameters[j].Name = string.Format("({0} *) __fixedLocals[{1}]", binding.Parameters[j].CSType.ParameterType.Substring(0, binding.Parameters[j].CSType.ParameterType.Length - 2), k++);
                }
            }
            ImplementMethod(code, errors, binding, i + 1, string.Concat(indent, "        "));
            code.AppendFormat("{0}    {1}", indent, '}');
            foreach (string fixedLocal in fixedLocals) {
                code.AppendFormat(", {0}", fixedLocal);
            }
            code.AppendLine(");");
            code.AppendFormat("{0}{1} finally {2}", indent, '}', '{');
            code.AppendLine();
            code.AppendFormat("{0}    Marshal.FreeHGlobal(ptr_{1});", indent, paramName);
            code.AppendLine();
            code.AppendFormat("{0}{1}", indent, '}');
            code.AppendLine();
        }

        void ImplementMethod(StringBuilder code, List<string> errors, CommandBinding binding, int i, string indent) {
            if (i < binding.Parameters.Count) {
                ParameterBinding param = binding.Parameters[i];
                if (param.CSType.ParameterType.EndsWith("[][][]")) {
                    errors.Add("Type has too many array dimensions.");
                    code.Append(indent);
                    code.AppendLine("throw new NotSupportedException();");
                } else if (param.CSType.ParameterType.EndsWith("[][]")) {
                    ImplementDoubleArrayMethod(code, errors, binding, i, indent, param.Name, param.CSType.ParameterType.Substring(0, param.CSType.ParameterType.Length - 4), param);
                } else if (param.CSType.ParameterType.EndsWith("[]")) {
                    if (param.CSType.ParameterType == "string[]") {
                        code.AppendFormat("{0}char[][] chars_{1} = @{1}.Select(s => s.ToCharArray()).ToArray();", indent, param.Name);
                        code.AppendLine();
                        ImplementDoubleArrayMethod(code, errors, binding, i, indent, string.Concat("chars_", param.Name), "char", param);
                    } else {
                        code.AppendFormat("{0}fixed ({1} *ptr_{2} = @{2}) {3}", indent, param.CSType.ParameterType.Substring(0, param.CSType.ParameterType.Length - 2), param.Name, '{');
                        code.AppendLine();
                        param.Name = string.Concat("ptr_", param.Name);
                        ImplementMethod(code, errors, binding, i + 1, string.Concat(indent, "    "));
                        code.Append(indent);
                        code.AppendLine("}");
                    }
                } else {
                    ImplementMethod(code, errors, binding, i + 1, indent);
                }
            } else {
                code.Append(indent);
                if (binding.ReturnCSType.ReturnType != "void") {
                    code.Append("return ");
                }
                code.AppendFormat("Native_{0}(", binding.CSName);
                bool first = true;
                foreach (ParameterBinding param in binding.Parameters) {
                    if (first) {
                        first = false;
                    } else {
                        code.Append(", ");
                    }
                    if (param.Name[0] >= 'a' && param.Name[0] <= 'z') {
                        code.Append("@");
                    }
                    code.AppendFormat(param.Name);
                }
                code.AppendLine(");");
            }
        }

        public void Generate(XmlDocument document, StringBuilder code, List<string> errors) {
            code.AppendLine("    unsafe partial class OpenGLContext : IRenderContext {");
            foreach (XmlElement command in document.GetElementsByTagName("commands")
                        .OfType<XmlElement>()
                        .SelectMany(
                            e => e.GetElementsByTagName("command").OfType<XmlElement>())) {
                CommandBinding binding;
                if (CommandBinding.TryParse(command, errors, out binding)) {
                    code.AppendFormat("        [DllImport(\"OpenGL32\", CallingConvention = CallingConvention.Cdecl, EntryPoint = \"{0}\")]", binding.CName);
                    code.AppendLine();
                    code.AppendFormat("        static extern {0} Native_{1}(", binding.ReturnCSType.ReturnType, binding.CSName);
                    bool first = true;
                    foreach (ParameterBinding param in binding.Parameters) {
                        if (first) {
                            first = false;
                        } else {
                            code.Append(", ");
                        }
                        code.AppendFormat("{0} @{1}", param.CSType.ParameterType.Replace("[]", "*").Replace("string*", "char**"), param.Name);
                    }
                    code.AppendLine(");");
                    code.AppendLine();
                    code.AppendFormat("        public {0} {1}(", binding.ReturnCSType.ReturnType, binding.CSName);
                    first = true;
                    foreach (ParameterBinding param in binding.Parameters) {
                        if (first) {
                            first = false;
                        } else {
                            code.Append(", ");
                        }
                        code.AppendFormat("{0} @{1}", param.CSType.ParameterType, param.Name);
                    }
                    code.AppendLine(") {");
                    ImplementMethod(code, errors, binding, 0, "            ");
                    code.AppendLine("        }");
                    code.AppendLine();
                }
            }
            if (code[code.Length - 1] == '\n') {
                code.Remove(code.Length - 1, 1);
            }
            code.AppendLine("    }");
            code.AppendLine();
        }
    }
}
