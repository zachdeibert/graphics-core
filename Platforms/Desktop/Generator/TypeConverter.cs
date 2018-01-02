using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    static class TypeConverter {
        static Dictionary<string, ConvertedType> DefaultConversions = new Dictionary<string, ConvertedType>();

        static TypeConverter() {
            Dictionary<string, ConvertedType> _ = DefaultConversions;
            _["void"] = new ConvertedType("void", null);
            _["void *"] = new ConvertedType("IntPtr", "byte[]");
            _["void **"] = _["void *const*"] = new ConvertedType("IntPtr", "byte[][]");
            _["char"] = new ConvertedType("byte");
            _["int8_t"] = _["signed char"] = new ConvertedType("sbyte");
            _["uint8_t"] = _["unsigned char"] = new ConvertedType("byte");
            _["int16_t"] = _["short"] = _["short int"] = _["signed short"] = _["signed short int"] = new ConvertedType("short");
            _["uint16_t"] = _["unsigned short"] = _["unsigned short int"] = new ConvertedType("ushort");
            _["int32_t"] = _["int"] = _["signed"] = _["signed int"] = new ConvertedType("int");
            _["uint32_t"] = _["unsigned"] = _["unsigned int"] = new ConvertedType("uint");
            _["int64_t"] = _["ptrdiff_t"] = _["long"] = _["long int"] = _["signed long"] = _["signed long int"] = _["long long"] = _["long long int"] = _["signed long long"] = _["signed long long int"] = new ConvertedType("long");
            _["uint64_t"] = _["unsigned long"] = _["unsigned long int"] = _["unsigned long long"] = _["unsigned long long int"] = new ConvertedType("ulong");
            _["float"] = new ConvertedType("float");
            _["double"] = new ConvertedType("double");
            _["GLboolean"] = new ConvertedType("bool");
            _["GLboolean*"] = new ConvertedType(_["GLboolean"]);
            _["GLhandleARB"] = _["GLsync"] = _["struct _cl_context*"] = _["struct _cl_event*"] = _["GLDEBUGPROC"] = _["GLDEBUGPROCAMD"] = _["GLDEBUGPROCARB"] = _["GLDEBUGPROCKHR"] = _["GLVULKANPROCNV"] = new ConvertedType("IntPtr");
            _["GLchar*"] = new ConvertedType("byte[]");
            _["GLchar**"] = new ConvertedType(_["GLchar*"]);
            _["GLcharARB*"] = new ConvertedType("byte[]");
            _["GLcharARB**"] = new ConvertedType(_["GLcharARB*"]);
        }

        static bool Convert(XmlElement types, string cType, out ConvertedType csType) {
            if (DefaultConversions.ContainsKey(cType)) {
                csType = DefaultConversions[cType];
                return true;
            } else {
                XmlElement type = types.ChildNodes.OfType<XmlElement>().FirstOrDefault(t => t.ChildNodes.OfType<XmlElement>().FirstOrDefault()?.InnerText?.Trim() == cType);
                if (type == null) {
                    csType = null;
                    return false;
                } else {
                    string typedef = type.ChildNodes.OfType<XmlText>().Select(e => e.Value.Trim()).FirstOrDefault(s => s.StartsWith("typedef "));
                    if (typedef == null) {
                        csType = null;
                        return false;
                    } else {
                        return Convert(types, typedef.Substring(8), out csType);
                    }
                }
            }
        }

        public static bool Convert(XmlDocument document, string cType, out ConvertedType csType) {
            if (cType.StartsWith("const ")) {
                cType = cType.Substring(6);
            }
            ConvertedType _csType;
            XmlElement types = (XmlElement) document.GetElementsByTagName("types").Item(0);
            bool res = Convert(types, cType, out _csType);
            if (!res && cType.EndsWith("*")) {
                if (res = Convert(types, cType.Substring(0, cType.Length - 1).Trim(), out _csType)) {
                    _csType = new ConvertedType(_csType);
                }
            }
            csType = _csType;
            return res;
        }
    }
}
