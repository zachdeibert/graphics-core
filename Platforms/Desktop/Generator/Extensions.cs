using System;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    static class Extensions {
        const char LowerCase = (char) ('a' - 'A');

        public static string ConstantToPascal(this string name) {
            if (name.StartsWith("GL_") && name[3] >= 'A' && name[3] <= 'Z') {
                name = name.Substring(3);
            }
            char[] chars = name.ToLower().ToCharArray();
            chars[0] -= LowerCase;
            for (int i = 1; i < chars.Length; ++i) {
                if (chars[i] == '_' && chars[i + 1] >= 'a' && chars[i + 1] <= 'z') {
                    chars[i + 1] -= LowerCase;
                }
            }
            return new string(chars).Replace("_", "");
        }

        public static string CommandToPascal(this string name) {
            if (name.StartsWith("gl") && name[2] >= 'A' && name[2] <= 'Z') {
                return name.Substring(2);
            } else {
                return string.Concat(name.Substring(0, 1).ToUpper(), name.Substring(1));
            }
        }
    }
}
