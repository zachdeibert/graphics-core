using System;
using System.IO;
using CppSharp;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.Generator {
    static class Entry {
        static void Main(string[] args) {
            Directory.CreateDirectory("../../../Natives");
            ConsoleDriver.Run(new OpenGLLibrary());
            if (File.Exists("../../../Natives/OpenGL.cs")) {
                File.Delete("../../../Natives/OpenGL.cs");
            }
            File.Move("Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.cs", "../../../Natives/OpenGL.cs");
            ConsoleDriver.Run(new GLFWLibrary());
            if (File.Exists("../../../Natives/GLFW.cs")) {
                File.Delete("../../../Natives/GLFW.cs");
            }
            File.Move("Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop.cs", "../../../Natives/GLFW.cs");
        }
    }
}
