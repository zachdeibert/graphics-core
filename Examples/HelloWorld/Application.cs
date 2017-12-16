using System;
using Com.GitHub.ZachDeibert.GraphicsCore;

namespace Examples.HelloWorld {
    [Application]
    public class Application : IApplication {
        public string Name => "Hello World";

        public ApplicationType Type => ApplicationType.OpenGL;
        IOpenGLContext GL;

        void Render() {
            GL.Clear(16384);
            GL.Begin(4);
            GL.Color3f(1, 0, 0);
            GL.Vertex2f(0, 0);
            GL.Color3f(0, 1, 0);
            GL.Vertex2f(0, 1);
            GL.Color3f(0, 0, 1);
            GL.Vertex2f(1, 1);
            GL.End();
        }

        public void Start(IRenderContext ctx) {
            GL = (IOpenGLContext) ctx;
            GL.Frame += Render;
        }

        public void Stop() {
        }
    }
}
