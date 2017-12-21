using System;

namespace Com.GitHub.ZachDeibert.GraphicsCore {
    public sealed class KeyboardInputSource {
        public event KeyHandler Press;
        public event KeyHandler Release;
        public event KeyHandler Repeat;
        public event CharHandler Type;

        internal void OnPress(Key key, KeyModifiers modifiers) {
            Press?.Invoke(key, modifiers);
        }

        internal void OnRelease(Key key, KeyModifiers modifiers) {
            Release?.Invoke(key, modifiers);
        }

        internal void OnRepeat(Key key, KeyModifiers modifiers) {
            Repeat?.Invoke(key, modifiers);
        }

        internal void OnType(char key, KeyModifiers modifiers) {
            Type?.Invoke(key, modifiers);
        }

        public delegate void KeyHandler(Key key, KeyModifiers modifiers);
        public delegate void CharHandler(char key, KeyModifiers modifiers);
    }
}
