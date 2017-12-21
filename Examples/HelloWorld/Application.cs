using System;
using Com.GitHub.ZachDeibert.GraphicsCore;

namespace Examples.HelloWorld {
    [Application]
    public class Application : IApplication {
        readonly static float[][] Colors = {
            new [] { 1f, 0f, 0f },
            new [] { 1f, 0.75f, 0f },
            new [] { 0.5f, 1f, 0f },
            new [] { 0f, 1f, 0.25f },
            new [] { 0f, 1f, 1f },
            new [] { 0f, 0.25f, 1f },
            new [] { 0.5f, 0f, 1f },
            new [] { 1f, 0f, 0.75f }
        };
        public string Name => "Hello World";
        public ApplicationType Type => ApplicationType.OpenGL;
        IOpenGLContext Gl;
        int ColorOffset;
        bool UpdateColorsEverFrame;

        void Render() {
            if (UpdateColorsEverFrame) {
                ++ColorOffset;
            }

            Gl.Clear(GL.COLOR_BUFFER_BIT);
            Gl.Begin(GL.TRIANGLES);

            Gl.Color3f(0.5f, 0.5f, 0.5f);
            Gl.Vertex2f(0, 0);
            Gl.Color3fv(Colors[(ColorOffset + 0) % 8]);
            Gl.Vertex2f(1, 1);
            Gl.Color3fv(Colors[(ColorOffset + 1) % 8]);
            Gl.Vertex2f(0, 1);

            Gl.Color3f(0.5f, 0.5f, 0.5f);
            Gl.Vertex2f(0, 0);
            Gl.Color3fv(Colors[(ColorOffset + 1) % 8]);
            Gl.Vertex2f(0, 1);
            Gl.Color3fv(Colors[(ColorOffset + 2) % 8]);
            Gl.Vertex2f(-1, 1);

            Gl.Color3f(0.5f, 0.5f, 0.5f);
            Gl.Vertex2f(0, 0);
            Gl.Color3fv(Colors[(ColorOffset + 2) % 8]);
            Gl.Vertex2f(-1, 1);
            Gl.Color3fv(Colors[(ColorOffset + 3) % 8]);
            Gl.Vertex2f(-1, 0);

            Gl.Color3f(0.5f, 0.5f, 0.5f);
            Gl.Vertex2f(0, 0);
            Gl.Color3fv(Colors[(ColorOffset + 3) % 8]);
            Gl.Vertex2f(-1, 0);
            Gl.Color3fv(Colors[(ColorOffset + 4) % 8]);
            Gl.Vertex2f(-1, -1);

            Gl.Color3f(0.5f, 0.5f, 0.5f);
            Gl.Vertex2f(0, 0);
            Gl.Color3fv(Colors[(ColorOffset + 4) % 8]);
            Gl.Vertex2f(-1, -1);
            Gl.Color3fv(Colors[(ColorOffset + 5) % 8]);
            Gl.Vertex2f(0, -1);

            Gl.Color3f(0.5f, 0.5f, 0.5f);
            Gl.Vertex2f(0, 0);
            Gl.Color3fv(Colors[(ColorOffset + 5) % 8]);
            Gl.Vertex2f(0, -1);
            Gl.Color3fv(Colors[(ColorOffset + 6) % 8]);
            Gl.Vertex2f(1, -1);

            Gl.Color3f(0.5f, 0.5f, 0.5f);
            Gl.Vertex2f(0, 0);
            Gl.Color3fv(Colors[(ColorOffset + 6) % 8]);
            Gl.Vertex2f(1, -1);
            Gl.Color3fv(Colors[(ColorOffset + 7) % 8]);
            Gl.Vertex2f(1, 0);

            Gl.Color3f(0.5f, 0.5f, 0.5f);
            Gl.Vertex2f(0, 0);
            Gl.Color3fv(Colors[(ColorOffset + 7) % 8]);
            Gl.Vertex2f(1, 0);
            Gl.Color3fv(Colors[(ColorOffset + 0) % 8]);
            Gl.Vertex2f(1, 1);

            Gl.End();
        }

        void HandleClick(MouseButton button, KeyModifiers modifiers) {
            if (modifiers == KeyModifiers.None) {
                ++ColorOffset;
            } else {
                UpdateColorsEverFrame = true;
            }
        }

        void HandleRelease(MouseButton button, KeyModifiers modifiers) {
            if (modifiers != KeyModifiers.None) {
                UpdateColorsEverFrame = false;
            }
        }

        public void Start(IRenderContext ctx) {
            Gl = (IOpenGLContext) ctx;
            Gl.Frame += Render;
            Gl.Input.Mouse.Click += HandleClick;
            Gl.Input.Mouse.Release += HandleRelease;
        }

        public void Stop() {
        }
    }
}
