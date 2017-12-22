using System;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    class ConvertedType {
        public readonly string ReturnType;
        public readonly string ParameterType;

        public ConvertedType(string returnType, string parameterType) {
            ReturnType = returnType;
            ParameterType = parameterType;
        }

        public ConvertedType(string type) : this(type, type) {
        }

        public ConvertedType(ConvertedType ptr) : this(null, string.Concat(ptr.ParameterType, "[]")) {
        }
    }
}
