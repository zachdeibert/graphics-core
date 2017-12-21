using System;

namespace Com.GitHub.ZachDeibert.GraphicsCore {
    public interface IRenderContext {
        ApplicationType Type {
            get;
        }

        InputSource Input {
            get;
        }

        event Action ShuttingDown;

        event Action Frame;
    }
}
