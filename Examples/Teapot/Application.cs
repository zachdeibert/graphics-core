using System;
using Com.GitHub.ZachDeibert.GraphicsCore;

namespace Examples.Teapot {
    [Application]
    public class Application : IApplication {
#region Arrays
        static readonly double[] NFactorialTimesThreeMinusNFactorialInverse = {
            0.16666666666666667,
            0.5,
            0.5,
            0.16666666666666667
        };
        static readonly int[,] TeapotPatches = {
            { 102, 103, 104, 105,   4,   5,   6,   7,   8,   9,  10,  11,  12,  13,  14,  15 },
            {  12,  13,  14,  15,  16,  17,  18,  19,  20,  21,  22,  23,  24,  25,  26,  27 },
            {  24,  25,  26,  27,  29,  30,  31,  32,  33,  34,  35,  36,  37,  38,  39,  40 },
            {  96,  96,  96,  96,  97,  98,  99, 100, 101, 101, 101, 101,   0,   1,   2,   3 },
            {   0,   1,   2,   3, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117 },
            {  41,  42,  43,  44,  45,  46,  47,  48,  49,  50,  51,  52,  53,  54,  55,  56 },
            {  53,  54,  55,  56,  57,  58,  59,  60,  61,  62,  63,  64,  28,  65,  66,  67 },
            {  68,  69,  70,  71,  72,  73,  74,  75,  76,  77,  78,  79,  80,  81,  82,  83 },
            {  80,  81,  82,  83,  84,  85,  86,  87,  88,  89,  90,  91,  92,  93,  94,  95 }
        };
        const int RotateXPatches = 5;
        static readonly double[,] TeapotVerticies = {
            {  0.2   ,  0     , 2.7     },
            {  0.2   , -0.112 , 2.7     },
            {  0.112 , -0.2   , 2.7     },
            {  0     , -0.2   , 2.7     },
            {  1.3375,  0     , 2.53125 },
            {  1.3375, -0.749 , 2.53125 },
            {  0.749 , -1.3375, 2.53125 },
            {  0     , -1.3375, 2.53125 },
            {  1.4375,  0     , 2.53125 },
            {  1.4375, -0.805 , 2.53125 },
            {  0.805 , -1.4375, 2.53125 },
            {  0     , -1.4375, 2.53125 },
            {  1.5   ,  0     , 2.4     },
            {  1.5   , -0.84  , 2.4     },
            {  0.84  , -1.5   , 2.4     },
            {  0     , -1.5   , 2.4     },
            {  1.75  ,  0     , 1.875   },
            {  1.75  , -0.98  , 1.875   },
            {  0.98  , -1.75  , 1.875   },
            {  0     , -1.75  , 1.875   },
            {  2     ,  0     , 1.35    },
            {  2     , -1.12  , 1.35    },
            {  1.12  , -2     , 1.35    },
            {  0     , -2     , 1.35    },
            {  2     ,  0     , 0.9     },
            {  2     , -1.12  , 0.9     },
            {  1.12  , -2     , 0.9     },
            {  0     , -2     , 0.9     },
            { -2     ,  0     , 0.9     },
            {  2     ,  0     , 0.45    },
            {  2     , -1.12  , 0.45    },
            {  1.12  , -2     , 0.45    },
            {  0     , -2     , 0.45    },
            {  1.5   ,  0     , 0.225   },
            {  1.5   , -0.84  , 0.225   },
            {  0.84  , -1.5   , 0.225   },
            {  0     , -1.5   , 0.225   },
            {  1.5   ,  0     , 0.15    },
            {  1.5   , -0.84  , 0.15    },
            {  0.84  , -1.5   , 0.15    },
            {  0     , -1.5   , 0.15    },
            { -1.6   ,  0     , 2.025   },
            { -1.6   , -0.3   , 2.025   },
            { -1.5   , -0.3   , 2.25    },
            { -1.5   ,  0     , 2.25    },
            { -2.3   ,  0     , 2.025   },
            { -2.3   , -0.3   , 2.025   },
            { -2.5   , -0.3   , 2.25    },
            { -2.5   ,  0     , 2.25    },
            { -2.7   ,  0     , 2.025   },
            { -2.7   , -0.3   , 2.025   },
            { -3     , -0.3   , 2.25    },
            { -3     ,  0     , 2.25    },
            { -2.7   ,  0     , 1.8     },
            { -2.7   , -0.3   , 1.8     },
            { -3     , -0.3   , 1.8     },
            { -3     ,  0     , 1.8     },
            { -2.7   ,  0     , 1.575   },
            { -2.7   , -0.3   , 1.575   },
            { -3     , -0.3   , 1.35    },
            { -3     ,  0     , 1.35    },
            { -2.5   ,  0     , 1.125   },
            { -2.5   , -0.3   , 1.125   },
            { -2.65  , -0.3   , 0.9375  },
            { -2.65  ,  0     , 0.9375  },
            { -2     , -0.3   , 0.9     },
            { -1.9   , -0.3   , 0.6     },
            { -1.9   ,  0     , 0.6     },
            {  1.7   ,  0     , 1.425   },
            {  1.7   , -0.66  , 1.425   },
            {  1.7   , -0.66  , 0.6     },
            {  1.7   ,  0     , 0.6     },
            {  2.6   ,  0     , 1.425   },
            {  2.6   , -0.66  , 1.425   },
            {  3.1   , -0.66  , 0.825   },
            {  3.1   ,  0     , 0.825   },
            {  2.3   ,  0     , 2.1     },
            {  2.3   , -0.25  , 2.1     },
            {  2.4   , -0.25  , 2.025   },
            {  2.4   ,  0     , 2.025   },
            {  2.7   ,  0     , 2.4     },
            {  2.7   , -0.25  , 2.4     },
            {  3.3   , -0.25  , 2.4     },
            {  3.3   ,  0     , 2.4     },
            {  2.8   ,  0     , 2.475   },
            {  2.8   , -0.25  , 2.475   },
            {  3.525 , -0.25  , 2.49375 },
            {  3.525 ,  0     , 2.49375 },
            {  2.9   ,  0     , 2.475   },
            {  2.9   , -0.15  , 2.475   },
            {  3.45  , -0.15  , 2.5125  },
            {  3.45  ,  0     , 2.5125  },
            {  2.8   ,  0     , 2.4     },
            {  2.8   , -0.15  , 2.4     },
            {  3.2   , -0.15  , 2.4     },
            {  3.2   ,  0     , 2.4     },
            {  0     ,  0     , 3.15    },
            {  0.8   ,  0     , 3.15    },
            {  0.8   , -0.45  , 3.15    },
            {  0.45  , -0.8   , 3.15    },
            {  0     , -0.8   , 3.15    },
            {  0     ,  0     , 2.85    },
            {  1.4   ,  0     , 2.4     },
            {  1.4   , -0.784 , 2.4     },
            {  0.784 , -1.4   , 2.4     },
            {  0     , -1.4   , 2.4     },
            {  0.4   ,  0     , 2.55    },
            {  0.4   , -0.224 , 2.55    },
            {  0.224 , -0.4   , 2.55    },
            {  0     , -0.4   , 2.55    },
            {  1.3   ,  0     , 2.55    },
            {  1.3   , -0.728 , 2.55    },
            {  0.728 , -1.3   , 2.55    },
            {  0     , -1.3   , 2.55    },
            {  1.3   ,  0     , 2.4     },
            {  1.3   , -0.728 , 2.4     },
            {  0.728 , -1.3   , 2.4     },
            {  0     , -1.3   , 2.4     }
        };
        const double CameraDistance = 6;
#endregion
        const double DeltaUV = 0.1;
        static readonly double SqrtTwoPi = Math.Sqrt(2 * Math.PI);
        public string Name => "Tea Pot";
        public ApplicationType Type => ApplicationType.OpenGL;
        IOpenGLContext Gl;
        double[] Axis;
        Random Random;

        double Factorial(int n) {
            double f = 1;
            while (n > 1) {
                f *= n--;
            }
            return f;
        }

        double BinomialCoefficient(int n, int k) {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        double BezierN(int n, int i, double u) {
            return BinomialCoefficient(n, i) * Math.Pow(u, i) * Math.Pow(1 - u, n - i);
        }

        double[] CalculateSurface(int n, double u, double v) {
            double[] point = new double[3];
            for (int i = 0; i < 4; ++i) {
                for (int j = 0; j < 4; ++j) {
                    double scalar = BezierN(3, i, u) * BezierN(3, j, v);
                    int controlI = i * 4 + j;
                    point[0] += scalar * TeapotVerticies[TeapotPatches[n, controlI], 0];
                    point[1] += scalar * TeapotVerticies[TeapotPatches[n, controlI], 1];
                    point[2] += scalar * TeapotVerticies[TeapotPatches[n, controlI], 2];
                }
            }
            return point;
        }

        void Render() {
            Gl.Rotated(1, Axis[0], Axis[1], Axis[2]);
            Gl.PushMatrix();
            Gl.Translated(0, 0, -1.575);
            Gl.Scaled(1, 1, 1.3);
            Axis[0] += RandomDouble() / 4;
            Axis[1] += RandomDouble() / 4;
            Axis[2] += RandomDouble() / 4;
            NormalizeAxis();
            Gl.Clear(GlClearBufferMask.ColorBufferBit | GlClearBufferMask.DepthBufferBit);
            Gl.Color3f(1, 1, 1);
            Gl.Begin(GlPrimitiveType.Triangles);
            for (int i = 0; i < TeapotPatches.GetLength(0); ++i) {
                double fu;
                for (double u = 0; u < 1; u = fu) {
                    fu = u + DeltaUV;
                    double[] ab = null;
                    double[] bb = null;
                    double fv;
                    for (double v = 0; v < 1; v = fv) {
                        fv = v + DeltaUV;
                        double[] aa;
                        if (ab == null) {
                            aa = CalculateSurface(i, u, v);
                        } else {
                            aa = ab;
                        }
                        double[] ba;
                        if (bb == null) {
                            ba = CalculateSurface(i, fu, v);
                        } else {
                            ba = bb;
                        }
                        ab = CalculateSurface(i, u, fv);
                        bb = CalculateSurface(i, fu, fv);
                        Gl.Vertex3dv(aa);
                        Gl.Vertex3dv(ab);
                        Gl.Vertex3dv(ba);
                        Gl.Vertex3dv(bb);
                        Gl.Vertex3dv(ab);
                        Gl.Vertex3dv(ba);
                        aa[1] *= -1;
                        ba[1] *= -1;
                        ab[1] *= -1;
                        bb[1] *= -1;
                        Gl.Vertex3dv(aa);
                        Gl.Vertex3dv(ab);
                        Gl.Vertex3dv(ba);
                        Gl.Vertex3dv(bb);
                        Gl.Vertex3dv(ab);
                        Gl.Vertex3dv(ba);
                        if (i < RotateXPatches) {
                            aa[0] *= -1;
                            ba[0] *= -1;
                            ab[0] *= -1;
                            bb[0] *= -1;
                            Gl.Vertex3dv(aa);
                            Gl.Vertex3dv(ab);
                            Gl.Vertex3dv(ba);
                            Gl.Vertex3dv(bb);
                            Gl.Vertex3dv(ab);
                            Gl.Vertex3dv(ba);
                            aa[1] *= -1;
                            ba[1] *= -1;
                            ab[1] *= -1;
                            bb[1] *= -1;
                            Gl.Vertex3dv(aa);
                            Gl.Vertex3dv(ab);
                            Gl.Vertex3dv(ba);
                            Gl.Vertex3dv(bb);
                            Gl.Vertex3dv(ab);
                            Gl.Vertex3dv(ba);
                            ab[0] *= -1;
                            bb[0] *= -1;
                        } else {
                            ab[1] *= -1;
                            bb[1] *= -1;
                        }
                    }
                }
            }
            Gl.End();
            Gl.PopMatrix();
        }

        void SetPerspective(double fov, double aspect, double near, double far) {
            double height = Math.Tan(fov / 2) * near;
            double width = height * aspect;
            Gl.Frustum(-width, width, -height, height, near, far);
        }

        void NormalizeAxis() {
            double mag = Math.Sqrt(Axis[0] * Axis[0] + Axis[1] * Axis[1] + Axis[2] * Axis[2]);
            Axis[0] /= mag;
            Axis[1] /= mag;
            Axis[2] /= mag;
        }

        double RandomDouble() {
            return 0.5 - Random.NextDouble();
        }

        public void Start(IRenderContext ctx) {
            Gl = (IOpenGLContext) ctx;
            Gl.Frame += Render;
            Gl.Enable(GlEnableCap.DepthTest);
            Gl.DepthFunc(GlDepthFunction.Lequal);
            Gl.MatrixMode(GlMatrixMode.Projection);
            SetPerspective(Math.PI / 2, 16.0 / 9.0, 1, 10);
            Gl.MatrixMode(GlMatrixMode.Modelview);
            Gl.Translated(0, 0, -CameraDistance);
            Axis = new double[3];
            Random = new Random();
            Axis[0] = RandomDouble();
            Axis[1] = RandomDouble();
            Axis[2] = RandomDouble();
        }

        public void Stop() {
        }
    }
}
