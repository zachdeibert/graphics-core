using System;

namespace Com.GitHub.ZachDeibert.GraphicsCore {
    public sealed class WindowEventSource {
        public event MoveHandler Move;
        public event SizeHandler Resize;
        public event Action Focus;
        public event Action Blur;
        public event Action Iconify;
        public event Action Restore;
        public event SizeHandler ViewportResize;

        internal void OnMove(int x, int y) {
            Move?.Invoke(x, y);
        }

        internal void OnResize(int width, int height) {
            Resize?.Invoke(width, height);
        }

        internal void OnFocus() {
            Focus?.Invoke();
        }

        internal void OnBlur() {
            Blur?.Invoke();
        }

        internal void OnIconify() {
            Iconify?.Invoke();
        }

        internal void OnRestore() {
            Restore?.Invoke();
        }

        internal void OnViewportReisze(int width, int height) {
            ViewportResize?.Invoke(width, height);
        }

        public delegate void MoveHandler(int x, int y);
        public delegate void SizeHandler(int width, int height);
    }
}
