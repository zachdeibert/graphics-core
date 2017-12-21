using System;
using Com.GitHub.ZachDeibert.GraphicsCore;

namespace Examples.HelloWorld {
    [Application]
    public class Application : IApplication {
        public string Name => "Hello World";

        public ApplicationType Type => ApplicationType.OpenGL;
        IOpenGLContext Gl;

        void Render() {
            Gl.Clear(GL.COLOR_BUFFER_BIT);
            Gl.Begin(GL.TRIANGLES);
            Gl.Color3f(1, 0, 0);
            Gl.Vertex2f(0, 0);
            Gl.Color3f(0, 1, 0);
            Gl.Vertex2f(0, 1);
            Gl.Color3f(0, 0, 1);
            Gl.Vertex2f(1, 1);
            Gl.End();
        }

        public void Start(IRenderContext ctx) {
            Gl = (IOpenGLContext) ctx;
            Gl.Frame += Render;
        }

        public void Stop() {
        }
    }
}
