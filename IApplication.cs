using System;

namespace Com.GitHub.ZachDeibert.GraphicsCore {
    public interface IApplication {
        string Name {
            get;
        }

        ApplicationType Type {
            get;
        }

        void Start(IRenderContext ctx);

        void Stop();
    }
}
