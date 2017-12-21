using System;

namespace Com.GitHub.ZachDeibert.GraphicsCore {
    public sealed class MouseInputSource {
        public event MoveHandler Scroll;
        public event MoveHandler Move;
        public event Action Enter;
        public event Action Leave;
        public event ClickHandler Click;
        public event ClickHandler Release;

        internal void OnScroll(double x, double y) {
            Scroll?.Invoke(x, y);
        }

        internal void OnMove(double x, double y) {
            Move?.Invoke(x, y);
        }

        internal void OnEnter() {
            Enter?.Invoke();
        }

        internal void OnLeave() {
            Leave?.Invoke();
        }

        internal void OnClick(MouseButton button, KeyModifiers modifiers) {
            Click?.Invoke(button, modifiers);
        }

        internal void OnRelease(MouseButton button, KeyModifiers modifiers) {
            Release?.Invoke(button, modifiers);
        }

        public delegate void MoveHandler(double x, double y);
        public delegate void ClickHandler(MouseButton button, KeyModifiers modifiers);
    }
}
