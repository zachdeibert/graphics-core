using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    class InterfaceGenerator : IGenerator {
        public string[] Imports => new [] {
            "System"
        };

        public string FileName => "../../../Natives/OpenGL.cs";

        public string Namespace => "Com.GitHub.ZachDeibert.GraphicsCore";

        public void Generate(XmlDocument document, StringBuilder code, List<string> errors) {
            code.AppendLine("    public interface IOpenGLContext : IRenderContext {");
            foreach (XmlElement command in document.GetElementsByTagName("commands")
                        .OfType<XmlElement>()
                        .SelectMany(
                            e => e.GetElementsByTagName("command").OfType<XmlElement>())) {
                CommandBinding binding;
                if (CommandBinding.TryParse(command, errors, out binding)) {
                    code.AppendFormat("        {0} {1}(", binding.ReturnCSType.ReturnType, binding.CSName);
                    bool first = true;
                    foreach (ParameterBinding param in binding.Parameters) {
                        if (first) {
                            first = false;
                        } else {
                            code.Append(", ");
                        }
                        code.AppendFormat("{0} @{1}", param.CSType.ParameterType, param.Name);
                    }
                    code.AppendLine(");");
                }
            }
            code.AppendLine("    }");
            code.AppendLine();
        }
    }
}
