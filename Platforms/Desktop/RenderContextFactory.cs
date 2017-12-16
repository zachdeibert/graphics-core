using System;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop {
    internal class RenderContextFactory : IRenderContextFactory {
        public IRenderContext CreateContext(ApplicationType type, string name) {
            switch (type) {
                case ApplicationType.OpenGL:
                    return new OpenGLContext(name);
                default:
                    throw new NotSupportedException();
            }
        }

        public bool SupportsApplication(ApplicationType type) {
            switch (type) {
                case ApplicationType.OpenGL:
                    return true;
                default:
                    return false;
            }
        }
    }
}
