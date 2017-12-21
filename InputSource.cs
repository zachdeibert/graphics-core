using System;

namespace Com.GitHub.ZachDeibert.GraphicsCore {
    public sealed class InputSource {
        public readonly KeyboardInputSource Keyboard = new KeyboardInputSource();
        public readonly MouseInputSource Mouse = new MouseInputSource();
        public readonly WindowEventSource Window = new WindowEventSource();
    }
}
