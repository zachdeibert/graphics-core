using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop {
    internal partial class OpenGLContext : IOpenGLContext, IRenderContextInternal {
        public ApplicationType Type => ApplicationType.OpenGL;
        public InputSource Input {
            get;
            private set;
        }
        public event Action ShuttingDown;
        public event Action Frame;
        List<Delegate> StrongReferences;
        GLFWwindow Window;

        public void Start() {
            int width = 0;
            int height = 0;
            GLFW.GlfwGetFramebufferSize(Window, ref width, ref height);
            Viewport(0, 0, width, height);
            while (GLFW.GlfwWindowShouldClose(Window) == 0) {
                Frame?.Invoke();
                GLFW.GlfwSwapBuffers(Window);
                GLFW.GlfwPollEvents();
            }
            ShuttingDown?.Invoke();
            GLFW.GlfwDestroyWindow(Window);
            GLFW.GlfwTerminate();
        }

#region GLFW Enum Conversions
        bool ConvertMouseButton(int id, out MouseButton btn) {
            if (id >= 0 && id < 8) {
                btn = (MouseButton) (id + 1);
                return true;
            } else {
                btn = default(MouseButton);
                return false;
            }
        }

        bool ConvertKeyModifiers(int id, out KeyModifiers mods) {
            mods = (KeyModifiers) (id & 0x0F);
            return true;
        }

        bool ConvertKey(int id, out Key key) {
            if (id < 0) {
                key = default(Key);
                return false;
            } else if (id < 128) {
                key = (Key) id;
                return true;
            } else if ((id >= 256 && id <= 269) || (id >= 280 && id <= 284) || (id >= 290 && id <= 314) || (id >= 320 && id <= 336) || (id >= 340 && id <= 348)) {
                key = (Key) id;
                return true;
            } else {
                key = default(Key);
                return false;
            }
        }
#endregion

#region GLFW Callbacks
        void KeyCallback(IntPtr win, int keyId, int scancode, int action, int modsId) {
            Key key;
            KeyModifiers mods;
            if (ConvertKey(keyId, out key) && ConvertKeyModifiers(modsId, out mods)) {
                switch (action) {
                    case 0:
                        Input.Keyboard.OnRelease(key, mods);
                        break;
                    case 1:
                        Input.Keyboard.OnPress(key, mods);
                        break;
                    case 2:
                        Input.Keyboard.OnRepeat(key, mods);
                        break;
                }
            }
        }

        void CharCallback(IntPtr win, uint codepoint) {
            Input.Keyboard.OnType((char) codepoint, KeyModifiers.None);
        }

        void ErrorCallback(int code, string description) {
            Console.Error.WriteLine("GLFW failed with error code {0}: {1}.", code, description);
        }

        void ScrollCallback(IntPtr win, double xoffset, double yoffset) {
            Input.Mouse.OnScroll(xoffset, yoffset);
        }

        void CharModsCallback(IntPtr win, uint codepoint, int modsId) {
            KeyModifiers mods;
            if (ConvertKeyModifiers(modsId, out mods) && mods != KeyModifiers.None) {
                Input.Keyboard.OnType((char) codepoint, mods);
            }
        }

        void CursorPosCallback(IntPtr win, double xpos, double ypos) {
            Input.Mouse.OnMove(xpos, ypos);
        }

        void WindowPosCallback(IntPtr win, int xpos, int ypos) {
            Input.Window.OnMove(xpos, ypos);
        }

        void WindowSizeCallback(IntPtr win, int width, int height) {
            Input.Window.OnResize(width, height);
        }

        void CursorEnterCallback(IntPtr win, int entered) {
            switch (entered) {
                case 0:
                    Input.Mouse.OnLeave();
                    break;
                case 1:
                    Input.Mouse.OnEnter();
                    break;
            }
        }

        void MouseButtonCallback(IntPtr win, int buttonId, int action, int modsId) {
            MouseButton btn;
            KeyModifiers mods;
            if (ConvertMouseButton(buttonId, out btn) && ConvertKeyModifiers(modsId, out mods)) {
                switch (action) {
                    case 0:
                        Input.Mouse.OnRelease(btn, mods);
                        break;
                    case 1:
                        Input.Mouse.OnClick(btn, mods);
                        break;
                }
            }
        }

        void WindowFocusCallback(IntPtr win, int focused) {
            switch (focused) {
                case 0:
                    Input.Window.OnBlur();
                    break;
                case 1:
                    Input.Window.OnFocus();
                    break;
            }
        }

        void WindowIconifyCallback(IntPtr win, int iconified) {
            switch (iconified) {
                case 0:
                    Input.Window.OnRestore();
                    break;
                case 1:
                    Input.Window.OnIconify();
                    break;
            }
        }

        void FrameBufferSizeCallback(IntPtr win, int width, int height) {
            Viewport(0, 0, width, height);
            Input.Window.OnViewportReisze(width, height);
        }
#endregion

#region Native Support
        unsafe void ConvertDoubleArray_bool(IntPtr val, bool[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (bool *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_bool(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_byte(IntPtr val, byte[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (byte *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_byte(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_sbyte(IntPtr val, sbyte[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (sbyte *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_sbyte(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_char(IntPtr val, char[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (char *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_char(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_decimal(IntPtr val, decimal[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (decimal *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_decimal(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_double(IntPtr val, double[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (double *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_double(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_float(IntPtr val, float[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (float *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_float(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_int(IntPtr val, int[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (int *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_int(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_uint(IntPtr val, uint[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (uint *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_uint(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_long(IntPtr val, long[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (long *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_long(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_ulong(IntPtr val, ulong[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (ulong *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_ulong(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_short(IntPtr val, short[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (short *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_short(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe void ConvertDoubleArray_ushort(IntPtr val, ushort[][] arr, void **ptr, int i, Action<void *[]> cb, params void *[]fixedLocals) {
            fixed (ushort *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    cb(fixedLocals);
                } else {
                    ConvertDoubleArray_ushort(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }
        unsafe T ConvertDoubleArray_bool<T>(IntPtr val, bool[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (bool *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_bool(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_byte<T>(IntPtr val, byte[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (byte *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_byte(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_sbyte<T>(IntPtr val, sbyte[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (sbyte *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_sbyte(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_char<T>(IntPtr val, char[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (char *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_char(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_decimal<T>(IntPtr val, decimal[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (decimal *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_decimal(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_double<T>(IntPtr val, double[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (double *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_double(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_float<T>(IntPtr val, float[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (float *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_float(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_int<T>(IntPtr val, int[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (int *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_int(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_uint<T>(IntPtr val, uint[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (uint *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_uint(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_long<T>(IntPtr val, long[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (long *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_long(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_ulong<T>(IntPtr val, ulong[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (ulong *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_ulong(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_short<T>(IntPtr val, short[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (short *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_short(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }

        unsafe T ConvertDoubleArray_ushort<T>(IntPtr val, ushort[][] arr, void **ptr, int i, Func<void *[], T> cb, params void *[]fixedLocals) {
            fixed (ushort *single = arr[i]) {
                ptr[i] = single;
                if (++i == arr.Length) {
                    return cb(fixedLocals);
                } else {
                    return ConvertDoubleArray_ushort(val, arr, ptr, i, cb, fixedLocals);
                }
            }
        }
#endregion

        internal OpenGLContext(string name) {
            if (GLFW.GlfwInit() == 0) {
                Console.Error.WriteLine("GLFW failed to initialize!");
                Environment.Exit(1);
            }
            Window = GLFW.GlfwCreateWindow(1920, 1080, name, null, null);
            if (Window == null) {
                Console.Error.WriteLine("GLFW failed to open window!");
                GLFW.GlfwTerminate();
                Environment.Exit(1);
            }
            Input = new InputSource();
            GLFW.GlfwMakeContextCurrent(Window);
            StrongReferences = new List<Delegate>();
            {
                GLFWkeyfun cb = KeyCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetKeyCallback(Window, cb);
            }
            {
                GLFWcharfun cb = CharCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetCharCallback(Window, cb);
            }
            {
                GLFWerrorfun cb = ErrorCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetErrorCallback(cb);
            }
            {
                GLFWscrollfun cb = ScrollCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetScrollCallback(Window, cb);
            }
            {
                GLFWcharmodsfun cb = CharModsCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetCharModsCallback(Window, cb);
            }
            {
                GLFWcursorposfun cb = CursorPosCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetCursorPosCallback(Window, cb);
            }
            {
                GLFWwindowposfun cb = WindowPosCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetWindowPosCallback(Window, cb);
            }
            {
                GLFWwindowsizefun cb = WindowSizeCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetWindowSizeCallback(Window, cb);
            }
            {
                GLFWcursorenterfun cb = CursorEnterCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetCursorEnterCallback(Window, cb);
            }
            {
                GLFWmousebuttonfun cb = MouseButtonCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetMouseButtonCallback(Window, cb);
            }
            {
                GLFWwindowfocusfun cb = WindowFocusCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetWindowFocusCallback(Window, cb);
            }
            {
                GLFWwindowiconifyfun cb = WindowIconifyCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetWindowIconifyCallback(Window, cb);
            }
            {
                GLFWframebuffersizefun cb = FrameBufferSizeCallback;
                StrongReferences.Add(cb);
                GLFW.GlfwSetFramebufferSizeCallback(Window, cb);
            }
        }
    }
}
