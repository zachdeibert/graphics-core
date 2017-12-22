using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    class CommandBinding {
        public string CName;
        public string CSName;
        public string ReturnCType;
        public ConvertedType ReturnCSType;
        public List<ParameterBinding> Parameters = new List<ParameterBinding>();

        public static bool TryParse(XmlElement command, List<string> errors, out CommandBinding binding) {
            XmlElement proto = (XmlElement) command.GetElementsByTagName("proto").Item(0);
            binding = new CommandBinding {
                ReturnCType = (proto.GetElementsByTagName("ptype").OfType<XmlElement>().FirstOrDefault()?.InnerText
                    ?? proto.ChildNodes.OfType<XmlText>().First().Value).Trim()
            };
            if (TypeConverter.Convert(command.OwnerDocument, binding.ReturnCType, out binding.ReturnCSType) && binding.ReturnCSType.ReturnType != null) {
                binding.CName = proto.GetElementsByTagName("name").Item(0).InnerText.Trim();
                binding.CSName = binding.CName.CommandToPascal();
                foreach (XmlElement param in command.GetElementsByTagName("param")) {
                    ParameterBinding parameterBinding;
                    if (ParameterBinding.TryParse(param, errors, out parameterBinding)) {
                        binding.Parameters.Add(parameterBinding);
                    } else {
                        return false;
                    }
                }
                return true;
            } else {
                errors.Add(string.Format("Unable to find method to convert type '{0}.'", binding.ReturnCType));
                return false;
            }
        }

        CommandBinding() {
        }
    }
}
