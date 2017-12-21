using System;
using Com.GitHub.ZachDeibert.GraphicsCore;

namespace Examples.HelloWorld {
    [Application]
    public class Application : IApplication {
        readonly static float[][] Colors = {
            new [] { 1f, 0f, 0f },
            new [] { 0f, 1f, 0f },
            new [] { 0f, 0f, 1f }
        };
        public string Name => "Hello World";
        public ApplicationType Type => ApplicationType.OpenGL;
        IOpenGLContext Gl;
        int ColorOffset;

        void Render() {
            Gl.Clear(GL.COLOR_BUFFER_BIT);
            Gl.Begin(GL.TRIANGLES);
            Gl.Color3fv(Colors[ColorOffset % 3]);
            Gl.Vertex2f(0, 0);
            Gl.Color3fv(Colors[(ColorOffset + 1) % 3]);
            Gl.Vertex2f(0, 1);
            Gl.Color3fv(Colors[(ColorOffset + 2) % 3]);
            Gl.Vertex2f(1, 1);
            Gl.End();
        }

        void HandleClick(MouseButton button, KeyModifiers modifiers) {
            ++ColorOffset;
        }

        public void Start(IRenderContext ctx) {
            Gl = (IOpenGLContext) ctx;
            Gl.Frame += Render;
            Gl.Input.Mouse.Click += HandleClick;
        }

        public void Stop() {
        }
    }
}
