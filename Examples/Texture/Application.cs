using System;
using System.Runtime.InteropServices;
using System.Text;
using Com.GitHub.ZachDeibert.GraphicsCore;

namespace Examples.Texture {
    [Application]
    public class Application : IApplication {
        const string FragmentShader = @"
            #version 130

            uniform sampler2D tex;

            void main() {
                gl_FragColor = texture2D(tex, vec2(gl_TexCoord[0].s, 1 - gl_TexCoord[0].t));
            }
        ";
        const string VertexShader = @"
            #version 130

            void main() {
                gl_TexCoord[0] = gl_MultiTexCoord0;
                gl_Position = ftransform();
            }
        ";
        public string Name => "Texture Example";
        public ApplicationType Type => ApplicationType.OpenGL;
        IOpenGLContext Gl;
        uint Texture;

        void Render() {
            Gl.Clear(GlClearBufferMask.ColorBufferBit);
            Gl.Begin(GlPrimitiveType.Quads);
            Gl.ActiveTexture(GlTextureUnit.Texture0);
            Gl.BindTexture(GlTextureTarget.Texture2d, Texture);
            Gl.TexCoord2f(0, 0);
            Gl.Vertex2f(-1, -1);
            Gl.TexCoord2f(1, 0);
            Gl.Vertex2f( 1, -1);
            Gl.TexCoord2f(1, 1);
            Gl.Vertex2f( 1,  1);
            Gl.TexCoord2f(0, 1);
            Gl.Vertex2f(-1,  1);
            Gl.End();
        }

        public void Start(IRenderContext ctx) {
            Gl = (IOpenGLContext) ctx;
            Gl.Frame += Render;
            uint[] textures = new uint[1];
            Gl.GenTextures(1, textures);
            Texture = textures[0];
            Gl.ActiveTexture(GlTextureUnit.Texture0);
            Gl.BindTexture(GlTextureTarget.Texture2d, Texture);
            byte[] pixels = {
                255, 0, 0, 255,
                255, 255, 0, 255,
                0, 0, 255, 255,
                0, 255, 255, 255
            };
            Gl.TexParameteri(GlTextureTarget.Texture2d, GlTextureParameterName.TextureMagFilter, GL.LINEAR);
            Gl.TexParameteri(GlTextureTarget.Texture2d, GlTextureParameterName.TextureMinFilter, GL.LINEAR);
            Gl.TexParameteri(GlTextureTarget.Texture2d, GlTextureParameterName.TextureWrapS, GL.CLAMP_TO_EDGE);
            Gl.TexParameteri(GlTextureTarget.Texture2d, GlTextureParameterName.TextureWrapT, GL.CLAMP_TO_EDGE);
            Gl.TexImage2D(GlTextureTarget.Texture2d, 0, GlInternalFormat.Rgba, 2, 2, 0, GlPixelFormat.Rgba, GlPixelType.UnsignedByte, pixels);
            Gl.GenerateMipmap(GlTextureTarget.Texture2d);
            uint vertexShader = Gl.CreateShader(GlShaderType.VertexShader);
            uint fragmentShader = Gl.CreateShader(GlShaderType.FragmentShader);
            Gl.ShaderSource(vertexShader, 1, new [] { Encoding.ASCII.GetBytes(VertexShader) }, new [] { Encoding.ASCII.GetByteCount(VertexShader) });
            Gl.CompileShader(vertexShader);
            int[] result = new int[1];
            Gl.GetShaderiv(vertexShader, GlShaderParameterName.CompileStatus, result);
            if (((GlBoolean) result[0]) == GlBoolean.False) {
                int[] len = new int[1];
                Gl.GetShaderiv(vertexShader, GlShaderParameterName.InfoLogLength, len);
                byte[] log = new byte[len[0]];
                Gl.GetShaderInfoLog(vertexShader, len[0], len, log);
                Console.Error.WriteLine("Unable to compile vertex shader.");
                Console.Error.Write(Encoding.ASCII.GetString(log));
            }
            Gl.ShaderSource(fragmentShader, 1, new [] { Encoding.ASCII.GetBytes(FragmentShader) }, new [] { Encoding.ASCII.GetByteCount(FragmentShader) });
            Gl.CompileShader(fragmentShader);
            Gl.GetShaderiv(fragmentShader, GlShaderParameterName.CompileStatus, result);
            if (((GlBoolean) result[0]) == GlBoolean.False) {
                int[] len = new int[1];
                Gl.GetShaderiv(fragmentShader, GlShaderParameterName.InfoLogLength, len);
                byte[] log = new byte[len[0]];
                Gl.GetShaderInfoLog(fragmentShader, len[0], len, log);
                Console.Error.WriteLine("Unable to compile fragment shader.");
                Console.Error.Write(Encoding.ASCII.GetString(log));
            }
            uint program = Gl.CreateProgram();
            Gl.AttachShader(program, vertexShader);
            Gl.AttachShader(program, fragmentShader);
            Gl.LinkProgram(program);
            Gl.GetProgramiv(fragmentShader, GlProgramPropertyARB.LinkStatus, result);
            if (((GlBoolean) result[0]) == GlBoolean.False) {
                int[] len = new int[1];
                Gl.GetProgramiv(program, GlProgramPropertyARB.InfoLogLength, len);
                byte[] log = new byte[len[0]];
                Gl.GetProgramInfoLog(program, len[0], len, log);
                Console.Error.WriteLine("Unable to link program.");
                Console.Error.WriteLine(Encoding.ASCII.GetString(log));
            }
            Gl.DetachShader(program, vertexShader);
            Gl.DetachShader(program, fragmentShader);
            Gl.DeleteShader(vertexShader);
            Gl.DeleteShader(fragmentShader);
            Gl.UseProgram(program);
            int loc = Gl.GetUniformLocation(program, Encoding.ASCII.GetBytes("tex\0"));
            Gl.Uniform1i(loc, 0);
        }

        public void Stop() {
        }
    }
}
