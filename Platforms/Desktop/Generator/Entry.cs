using System;
using System.IO;
using CppSharp;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    static class Entry {
        static void Main(string[] args) {
            Directory.CreateDirectory("../../../Natives");
            ConsoleDriver.Run(new OpenGLLibrary());
            File.Move("Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.cs", "../../../Natives/OpenGL.cs");
        }
    }
}
