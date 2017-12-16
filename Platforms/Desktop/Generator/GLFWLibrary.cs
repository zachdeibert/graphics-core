using System;
using System.IO;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    class GLFWLibrary : ILibrary {
        public void Postprocess(Driver driver, ASTContext ctx) {

        }

        public void Preprocess(Driver driver, ASTContext ctx) {

        }

        public void Setup(Driver driver) {
            driver.Options.GeneratorKind = GeneratorKind.CSharp;
            Module module = driver.Options.AddModule("Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop");
            File.Copy("glfw\\include\\GLFW\\glfw3.h", "GLFW.h");
            module.IncludeDirs.Add(".");
            module.Headers.Add("GLFW.h");
            module.LibraryDirs.Add("glfw\\lib-vc2015");
            module.Libraries.Add("glfw3.lib");
        }

        public void SetupPasses(Driver driver) {

        }
    }
}
