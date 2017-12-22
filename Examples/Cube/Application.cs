using System;
using Com.GitHub.ZachDeibert.GraphicsCore;

namespace Examples.Cube {
    [Application]
    public class Application : IApplication {
        public string Name => "Cube";
        public ApplicationType Type => ApplicationType.OpenGL;
        IOpenGLContext Gl;
        float[] Axis;
        Random Random;

        void Render() {
            Gl.Rotatef(1, Axis[0], Axis[1], Axis[2]);
            Axis[0] += RandomFloat() / 4;
            Axis[1] += RandomFloat() / 4;
            Axis[2] += RandomFloat() / 4;
            NormalizeAxis();

            Gl.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
            Gl.Begin(GL.TRIANGLES);

            Gl.Color3f(1, 0, 0);
            Gl.Vertex3f(1, 1, 1);
            Gl.Vertex3f(1, -1, 1);
            Gl.Vertex3f(-1, 1, 1);
            Gl.Vertex3f(-1, -1, 1);
            Gl.Vertex3f(1, -1, 1);
            Gl.Vertex3f(-1, 1, 1);

            Gl.Color3f(0, 1, 1);
            Gl.Vertex3f(1, 1, -1);
            Gl.Vertex3f(1, -1, -1);
            Gl.Vertex3f(-1, 1, -1);
            Gl.Vertex3f(-1, -1, -1);
            Gl.Vertex3f(1, -1, -1);
            Gl.Vertex3f(-1, 1, -1);

            Gl.Color3f(0, 1, 0);
            Gl.Vertex3f(1, 1, 1);
            Gl.Vertex3f(1, 1, -1);
            Gl.Vertex3f(1, -1, 1);
            Gl.Vertex3f(1, -1, -1);
            Gl.Vertex3f(1, 1, -1);
            Gl.Vertex3f(1, -1, 1);

            Gl.Color3f(1, 0, 1);
            Gl.Vertex3f(-1, 1, 1);
            Gl.Vertex3f(-1, 1, -1);
            Gl.Vertex3f(-1, -1, 1);
            Gl.Vertex3f(-1, -1, -1);
            Gl.Vertex3f(-1, 1, -1);
            Gl.Vertex3f(-1, -1, 1);

            Gl.Color3f(0, 0, 1);
            Gl.Vertex3f(1, 1, 1);
            Gl.Vertex3f(1, 1, -1);
            Gl.Vertex3f(-1, 1, 1);
            Gl.Vertex3f(-1, 1, -1);
            Gl.Vertex3f(1, 1, -1);
            Gl.Vertex3f(-1, 1, 1);

            Gl.Color3f(1, 1, 0);
            Gl.Vertex3f(1, -1, 1);
            Gl.Vertex3f(1, -1, -1);
            Gl.Vertex3f(-1, -1, 1);
            Gl.Vertex3f(-1, -1, -1);
            Gl.Vertex3f(1, -1, -1);
            Gl.Vertex3f(-1, -1, 1);

            Gl.End();
        }

        void SetPerspective(double fov, double aspect, double near, double far) {
            double height = Math.Tan(fov / 2) * near;
            double width = height * aspect;
            Gl.Frustum(-width, width, -height, height, near, far);
        }

        void NormalizeAxis() {
            float mag = (float) Math.Sqrt(Axis[0] * Axis[0] + Axis[1] * Axis[1] + Axis[2] * Axis[2]);
            Axis[0] /= mag;
            Axis[1] /= mag;
            Axis[2] /= mag;
        }

        float RandomFloat() {
            return (float) (0.5 - Random.NextDouble());
        }

        public void Start(IRenderContext ctx) {
            Gl = (IOpenGLContext) ctx;
            Gl.Frame += Render;
            Gl.Enable(GL.DEPTH_TEST);
            Gl.DepthFunc(GL.LEQUAL);
            Gl.MatrixMode(GL.PROJECTION);
            SetPerspective(Math.PI / 2, 16.0 / 9.0, 1, 7);
            Gl.MatrixMode(GL.MODELVIEW);
            Gl.Translatef(0, 0, -4);
            Axis = new float[3];
            Random = new Random();
            Axis[0] = RandomFloat();
            Axis[1] = RandomFloat();
            Axis[2] = RandomFloat();
        }

        public void Stop() {
        }
    }
}
