using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    class EnumGenerator : IGenerator {
        public string[] Imports => new [] {
            "System"
        };

        public string FileName => "../../../Natives/OpenGL.cs";

        public string Namespace => "Com.GitHub.ZachDeibert.GraphicsCore";

        public void Generate(XmlDocument document, StringBuilder code, List<string> errors) {
            XmlElement groups = (XmlElement) document.GetElementsByTagName("groups").Item(0);
            foreach (XmlElement element in groups.ChildNodes.OfType<XmlElement>()) {
                code.AppendFormat("    public enum Gl{0} : uint {1}", element.Attributes["name"].Value, '{');
                code.AppendLine();
                HashSet<string> names = new HashSet<string>();
                foreach (XmlElement val in element.ChildNodes.OfType<XmlElement>()) {
                    string name = val.Attributes["name"].Value;
                    if (!names.Contains(name)) {
                        names.Add(name);
                        XmlElement value = document.GetElementsByTagName("enums")
                                .OfType<XmlElement>()
                                .SelectMany(e => e.ChildNodes.OfType<XmlElement>())
                                .FirstOrDefault(e => e.Attributes["name"]?.Value == name);
                        if (value == null) {
                            errors.Add(string.Format("Unable to find value for constant '{0}.'", name));
                        } else {
                            code.AppendFormat("        {0} = {1},", name.ConstantToPascal(), value.Attributes["value"].Value);
                            code.AppendLine();
                        }
                    }
                }
                code.AppendLine("    }");
                code.AppendLine();
            }
        }
    }
}
