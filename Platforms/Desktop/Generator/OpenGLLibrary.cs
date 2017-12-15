using System;
using System.IO;
using System.Linq;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    class OpenGLLibrary : ILibrary {
        public void Postprocess(Driver driver, ASTContext ctx) {
            
        }

        public void Preprocess(Driver driver, ASTContext ctx) {
            
        }

        public void Setup(Driver driver) {
            driver.Options.GeneratorKind = GeneratorKind.CSharp;
            Module module = driver.Options.AddModule("Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop");
            module.IncludeDirs.Add(".");
            module.Headers.Add("OpenGL.h");
            string includeDir = Directory.GetDirectories("C:\\Program Files (x86)\\Windows Kits").SelectMany(d => Directory.GetDirectories(Path.Combine(d, "Include"))).First();
            File.WriteAllText("OpenGL.h", string.Concat("#include <windows.h>\n", File.ReadAllText(Path.Combine(includeDir, "um\\gl\\GL.h"))));
            module.LibraryDirs.Add(Path.Combine(Directory.GetDirectories("C:\\Program Files (x86)\\Windows Kits").SelectMany(d => Directory.GetDirectories(Path.Combine(d, "Lib"))).First(), "um\\x64"));
            module.Libraries.Add("OpenGL32.Lib");
        }

        public void SetupPasses(Driver driver) {
            
        }
    }
}
