using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    class ParameterBinding {
        public string Name;
        public string CType;
        public ConvertedType CSType;

        public static bool TryParse(XmlElement param, List<string> errors, out ParameterBinding binding) {
            ParameterBinding _binding = binding = new ParameterBinding();
            if (param.HasAttribute("group")) {
                XmlElement groups = (XmlElement) param.OwnerDocument.GetElementsByTagName("groups").Item(0);
                binding.CType = param.Attributes["group"].Value;
                if (groups.ChildNodes.OfType<XmlElement>().Any(e => e.Attributes["name"].Value == _binding.CType)) {
                    string csType = string.Concat("Gl", binding.CType);
                    csType = string.Concat(csType, new string(param.ChildNodes.OfType<XmlText>().SelectMany(n => n.Value).Where(v => v == '*').SelectMany(c => "[]").ToArray()));
                    binding.CSType = new ConvertedType(csType);
                }
            }
            if (binding.CSType == null) {
                XmlElement ptype = (XmlElement) param.GetElementsByTagName("ptype").Item(0);
                if (ptype == null) {
                    binding.CType = param.ChildNodes.OfType<XmlText>().First().Value.Trim();
                } else {
                    binding.CType = ptype.InnerText.Trim();
                    binding.CType = string.Concat(binding.CType, new string(param.ChildNodes.OfType<XmlText>().SelectMany(n => n.Value).Where(v => v == '*').ToArray()));
                }
                ConvertedType t;
                if (TypeConverter.Convert(param.OwnerDocument, binding.CType, out t) && t.ParameterType != null) {
                    binding.CSType = t;
                } else {
                    errors.Add(string.Format("Unable to find method to convert type '{0}.'", binding.CType));
                    return false;
                }
            }
            XmlElement paramName = (XmlElement) param.GetElementsByTagName("name").Item(0);
            binding.Name = paramName.InnerText.Trim();
            return true;
        }

        ParameterBinding() {
        }
    }
}
