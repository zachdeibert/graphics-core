using System;

namespace Com.GitHub.ZachDeibert.GraphicsCore {
    internal interface IRenderContextFactory {
        bool SupportsApplication(ApplicationType type);

        IRenderContext CreateContext(ApplicationType type, string name);
    }
}
