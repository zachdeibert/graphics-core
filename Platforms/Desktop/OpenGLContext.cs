using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop {
    internal class OpenGLContext : IOpenGLContext, IRenderContextInternal {
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

#region OpenGL Calls
        public void Accum(uint op, float value) {
            OpenGL.GlAccum(op, value);
        }

        public void AlphaFunc(uint func, float @ref) {
            OpenGL.GlAlphaFunc(func, @ref);
        }

        public void ArrayElement(int i) {
            OpenGL.GlArrayElement(i);
        }

        public void Begin(uint mode) {
            OpenGL.GlBegin(mode);
        }

        public void BindTexture(uint target, uint texture) {
            OpenGL.GlBindTexture(target, texture);
        }

        public void BlendFunc(uint sfactor, uint dfactor) {
            OpenGL.GlBlendFunc(sfactor, dfactor);
        }

        public void CallList(uint list) {
            OpenGL.GlCallList(list);
        }

        public void CallLists(int n, uint type, IntPtr lists) {
            OpenGL.GlCallLists(n, type, lists);
        }

        public void Clear(uint mask) {
            OpenGL.GlClear(mask);
        }

        public void ClearAccum(float red, float green, float blue, float alpha) {
            OpenGL.GlClearAccum(red, green, blue, alpha);
        }

        public void ClearColor(float red, float green, float blue, float alpha) {
            OpenGL.GlClearColor(red, green, blue, alpha);
        }

        public void ClearDepth(double depth) {
            OpenGL.GlClearDepth(depth);
        }

        public void ClearIndex(float c) {
            OpenGL.GlClearIndex(c);
        }

        public void ClearStencil(int s) {
            OpenGL.GlClearStencil(s);
        }

        public void ClipPlane(uint plane, double[] equation) {
            OpenGL.GlClipPlane(plane, equation);
        }

        public void Color3b(sbyte red, sbyte green, sbyte blue) {
            OpenGL.GlColor3b(red, green, blue);
        }

        public void Color3d(double red, double green, double blue) {
            OpenGL.GlColor3d(red, green, blue);
        }

        public void Color3dv(double[] v) {
            OpenGL.GlColor3dv( v);
        }

        public void Color3f(float red, float green, float blue) {
            OpenGL.GlColor3f(red, green, blue);
        }

        public void Color3fv(float[] v) {
            OpenGL.GlColor3fv( v);
        }

        public void Color3i(int red, int green, int blue) {
            OpenGL.GlColor3i(red, green, blue);
        }

        public void Color3iv(int[] v) {
            OpenGL.GlColor3iv( v);
        }

        public void Color3s(short red, short green, short blue) {
            OpenGL.GlColor3s(red, green, blue);
        }

        public void Color3sv(short[] v) {
            OpenGL.GlColor3sv( v);
        }

        public void Color3ub(byte red, byte green, byte blue) {
            OpenGL.GlColor3ub(red, green, blue);
        }

        public void Color3ui(uint red, uint green, uint blue) {
            OpenGL.GlColor3ui(red, green, blue);
        }

        public void Color3uiv(uint[] v) {
            OpenGL.GlColor3uiv( v);
        }

        public void Color3us(ushort red, ushort green, ushort blue) {
            OpenGL.GlColor3us(red, green, blue);
        }

        public void Color3usv(ushort[] v) {
            OpenGL.GlColor3usv( v);
        }

        public void Color4b(sbyte red, sbyte green, sbyte blue, sbyte alpha) {
            OpenGL.GlColor4b(red, green, blue, alpha);
        }

        public void Color4d(double red, double green, double blue, double alpha) {
            OpenGL.GlColor4d(red, green, blue, alpha);
        }

        public void Color4dv(double[] v) {
            OpenGL.GlColor4dv( v);
        }

        public void Color4f(float red, float green, float blue, float alpha) {
            OpenGL.GlColor4f(red, green, blue, alpha);
        }

        public void Color4fv(float[] v) {
            OpenGL.GlColor4fv( v);
        }

        public void Color4i(int red, int green, int blue, int alpha) {
            OpenGL.GlColor4i(red, green, blue, alpha);
        }

        public void Color4iv(int[] v) {
            OpenGL.GlColor4iv( v);
        }

        public void Color4s(short red, short green, short blue, short alpha) {
            OpenGL.GlColor4s(red, green, blue, alpha);
        }

        public void Color4sv(short[] v) {
            OpenGL.GlColor4sv( v);
        }

        public void Color4ub(byte red, byte green, byte blue, byte alpha) {
            OpenGL.GlColor4ub(red, green, blue, alpha);
        }

        public void Color4ui(uint red, uint green, uint blue, uint alpha) {
            OpenGL.GlColor4ui(red, green, blue, alpha);
        }

        public void Color4uiv(uint[] v) {
            OpenGL.GlColor4uiv( v);
        }

        public void Color4us(ushort red, ushort green, ushort blue, ushort alpha) {
            OpenGL.GlColor4us(red, green, blue, alpha);
        }

        public void Color4usv(ushort[] v) {
            OpenGL.GlColor4usv( v);
        }

        public void ColorMask(byte red, byte green, byte blue, byte alpha) {
            OpenGL.GlColorMask(red, green, blue, alpha);
        }

        public void ColorMaterial(uint face, uint mode) {
            OpenGL.GlColorMaterial(face, mode);
        }

        public void ColorPointer(int size, uint type, int stride, IntPtr pointer) {
            OpenGL.GlColorPointer(size, type, stride, pointer);
        }

        public void CopyPixels(int x, int y, int width, int height, uint type) {
            OpenGL.GlCopyPixels(x, y, width, height, type);
        }

        public void CopyTexImage1D(uint target, int level, uint internalFormat, int x, int y, int width, int border) {
            OpenGL.GlCopyTexImage1D(target, level, internalFormat, x, y, width, border);
        }

        public void CopyTexImage2D(uint target, int level, uint internalFormat, int x, int y, int width, int height, int border) {
            OpenGL.GlCopyTexImage2D(target, level, internalFormat, x, y, width, height, border);
        }

        public void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width) {
            OpenGL.GlCopyTexSubImage1D(target, level, xoffset, x, y, width);
        }

        public void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
            OpenGL.GlCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
        }

        public void CullFace(uint mode) {
            OpenGL.GlCullFace(mode);
        }

        public void DeleteLists(uint list, int range) {
            OpenGL.GlDeleteLists(list, range);
        }

        public void DeleteTextures(int n, uint[] textures) {
            OpenGL.GlDeleteTextures(n, textures);
        }

        public void DepthFunc(uint func) {
            OpenGL.GlDepthFunc(func);
        }

        public void DepthMask(byte flag) {
            OpenGL.GlDepthMask(flag);
        }

        public void DepthRange(double zNear, double zFar) {
            OpenGL.GlDepthRange(zNear, zFar);
        }

        public void Disable(uint cap) {
            OpenGL.GlDisable(cap);
        }

        public void DisableClientState(uint array) {
            OpenGL.GlDisableClientState(array);
        }

        public void DrawArrays(uint mode, int first, int count) {
            OpenGL.GlDrawArrays(mode, first, count);
        }

        public void DrawBuffer(uint mode) {
            OpenGL.GlDrawBuffer(mode);
        }

        public void DrawElements(uint mode, int count, uint type, IntPtr indices) {
            OpenGL.GlDrawElements(mode, count, type, indices);
        }

        public void DrawPixels(int width, int height, uint format, uint type, IntPtr pixels) {
            OpenGL.GlDrawPixels(width, height, format, type, pixels);
        }

        public void EdgeFlag(byte flag) {
            OpenGL.GlEdgeFlag(flag);
        }

        public void EdgeFlagPointer(int stride, IntPtr pointer) {
            OpenGL.GlEdgeFlagPointer(stride, pointer);
        }

        public void Enable(uint cap) {
            OpenGL.GlEnable(cap);
        }

        public void EnableClientState(uint array) {
            OpenGL.GlEnableClientState(array);
        }

        public void End() {
            OpenGL.GlEnd();
        }

        public void EndList() {
            OpenGL.GlEndList();
        }

        public void EvalCoord1d(double u) {
            OpenGL.GlEvalCoord1d(u);
        }

        public void EvalCoord1dv(double[] u) {
            OpenGL.GlEvalCoord1dv( u);
        }

        public void EvalCoord1f(float u) {
            OpenGL.GlEvalCoord1f(u);
        }

        public void EvalCoord1fv(float[] u) {
            OpenGL.GlEvalCoord1fv( u);
        }

        public void EvalCoord2d(double u, double v) {
            OpenGL.GlEvalCoord2d(u, v);
        }

        public void EvalCoord2dv(double[] u) {
            OpenGL.GlEvalCoord2dv( u);
        }

        public void EvalCoord2f(float u, float v) {
            OpenGL.GlEvalCoord2f(u, v);
        }

        public void EvalCoord2fv(float[] u) {
            OpenGL.GlEvalCoord2fv( u);
        }

        public void EvalMesh1(uint mode, int i1, int i2) {
            OpenGL.GlEvalMesh1(mode, i1, i2);
        }

        public void EvalMesh2(uint mode, int i1, int i2, int j1, int j2) {
            OpenGL.GlEvalMesh2(mode, i1, i2, j1, j2);
        }

        public void EvalPoint1(int i) {
            OpenGL.GlEvalPoint1(i);
        }

        public void EvalPoint2(int i, int j) {
            OpenGL.GlEvalPoint2(i, j);
        }

        public void FeedbackBuffer(int size, uint type, float[] buffer) {
            OpenGL.GlFeedbackBuffer(size, type, buffer);
        }

        public void Finish() {
            OpenGL.GlFinish();
        }

        public void Flush() {
            OpenGL.GlFlush();
        }

        public void Fogf(uint pname, float param) {
            OpenGL.GlFogf(pname, param);
        }

        public void Fogfv(uint pname, float[] @params) {
            OpenGL.GlFogfv(pname, @params);
        }

        public void Fogi(uint pname, int param) {
            OpenGL.GlFogi(pname, param);
        }

        public void Fogiv(uint pname, int[] @params) {
            OpenGL.GlFogiv(pname, @params);
        }

        public void FrontFace(uint mode) {
            OpenGL.GlFrontFace(mode);
        }

        public void Frustum(double left, double right, double bottom, double top, double zNear, double zFar) {
            OpenGL.GlFrustum(left, right, bottom, top, zNear, zFar);
        }

        public uint GenLists(int range) {
            return OpenGL.GlGenLists(range);
        }

        public void GenTextures(int n, uint[] textures) {
            OpenGL.GlGenTextures(n, textures);
        }

        public void GetClipPlane(uint plane, double[] equation) {
            OpenGL.GlGetClipPlane(plane, equation);
        }

        public void GetDoublev(uint pname, double[] @params) {
            OpenGL.GlGetDoublev(pname, @params);
        }

        public uint GetError() {
            return OpenGL.GlGetError();
        }

        public void GetFloatv(uint pname, float[] @params) {
            OpenGL.GlGetFloatv(pname, @params);
        }

        public void GetIntegerv(uint pname, int[] @params) {
            OpenGL.GlGetIntegerv(pname, @params);
        }

        public void GetLightfv(uint light, uint pname, float[] @params) {
            OpenGL.GlGetLightfv(light, pname, @params);
        }

        public void GetLightiv(uint light, uint pname, int[] @params) {
            OpenGL.GlGetLightiv(light, pname, @params);
        }

        public void GetMapdv(uint target, uint query, double[] v) {
            OpenGL.GlGetMapdv(target, query, v);
        }

        public void GetMapfv(uint target, uint query, float[] v) {
            OpenGL.GlGetMapfv(target, query, v);
        }

        public void GetMapiv(uint target, uint query, int[] v) {
            OpenGL.GlGetMapiv(target, query, v);
        }

        public void GetMaterialfv(uint face, uint pname, float[] @params) {
            OpenGL.GlGetMaterialfv(face, pname, @params);
        }

        public void GetMaterialiv(uint face, uint pname, int[] @params) {
            OpenGL.GlGetMaterialiv(face, pname, @params);
        }

        public void GetPixelMapfv(uint map, float[] values) {
            OpenGL.GlGetPixelMapfv(map, values);
        }

        public void GetPixelMapuiv(uint map, uint[] values) {
            OpenGL.GlGetPixelMapuiv(map, values);
        }

        public void GetPixelMapusv(uint map, ushort[] values) {
            OpenGL.GlGetPixelMapusv(map, values);
        }

        public void GetTexEnvfv(uint target, uint pname, float[] @params) {
            OpenGL.GlGetTexEnvfv(target, pname, @params);
        }

        public void GetTexEnviv(uint target, uint pname, int[] @params) {
            OpenGL.GlGetTexEnviv(target, pname, @params);
        }

        public void GetTexGendv(uint coord, uint pname, double[] @params) {
            OpenGL.GlGetTexGendv(coord, pname, @params);
        }

        public void GetTexGenfv(uint coord, uint pname, float[] @params) {
            OpenGL.GlGetTexGenfv(coord, pname, @params);
        }

        public void GetTexGeniv(uint coord, uint pname, int[] @params) {
            OpenGL.GlGetTexGeniv(coord, pname, @params);
        }

        public void GetTexImage(uint target, int level, uint format, uint type, IntPtr pixels) {
            OpenGL.GlGetTexImage(target, level, format, type, pixels);
        }

        public void GetTexLevelParameterfv(uint target, int level, uint pname, float[] @params) {
            OpenGL.GlGetTexLevelParameterfv(target, level, pname, @params);
        }

        public void GetTexLevelParameteriv(uint target, int level, uint pname, int[] @params) {
            OpenGL.GlGetTexLevelParameteriv(target, level, pname, @params);
        }

        public void GetTexParameterfv(uint target, uint pname, float[] @params) {
            OpenGL.GlGetTexParameterfv(target, pname, @params);
        }

        public void GetTexParameteriv(uint target, uint pname, int[] @params) {
            OpenGL.GlGetTexParameteriv(target, pname, @params);
        }

        public void Hint(uint target, uint mode) {
            OpenGL.GlHint(target, mode);
        }

        public void IndexMask(uint mask) {
            OpenGL.GlIndexMask(mask);
        }

        public void IndexPointer(uint type, int stride, IntPtr pointer) {
            OpenGL.GlIndexPointer(type, stride, pointer);
        }

        public void Indexd(double c) {
            OpenGL.GlIndexd(c);
        }

        public void Indexdv(double[] c) {
            OpenGL.GlIndexdv( c);
        }

        public void Indexf(float c) {
            OpenGL.GlIndexf(c);
        }

        public void Indexfv(float[] c) {
            OpenGL.GlIndexfv( c);
        }

        public void Indexi(int c) {
            OpenGL.GlIndexi(c);
        }

        public void Indexiv(int[] c) {
            OpenGL.GlIndexiv( c);
        }

        public void Indexs(short c) {
            OpenGL.GlIndexs(c);
        }

        public void Indexsv(short[] c) {
            OpenGL.GlIndexsv( c);
        }

        public void Indexub(byte c) {
            OpenGL.GlIndexub(c);
        }

        public void InitNames() {
            OpenGL.GlInitNames();
        }

        public void InterleavedArrays(uint format, int stride, IntPtr pointer) {
            OpenGL.GlInterleavedArrays(format, stride, pointer);
        }

        public byte IsEnabled(uint cap) {
            return OpenGL.GlIsEnabled(cap);
        }

        public byte IsList(uint list) {
            return OpenGL.GlIsList(list);
        }

        public byte IsTexture(uint texture) {
            return OpenGL.GlIsTexture(texture);
        }

        public void LightModelf(uint pname, float param) {
            OpenGL.GlLightModelf(pname, param);
        }

        public void LightModelfv(uint pname, float[] @params) {
            OpenGL.GlLightModelfv(pname, @params);
        }

        public void LightModeli(uint pname, int param) {
            OpenGL.GlLightModeli(pname, param);
        }

        public void LightModeliv(uint pname, int[] @params) {
            OpenGL.GlLightModeliv(pname, @params);
        }

        public void Lightf(uint light, uint pname, float param) {
            OpenGL.GlLightf(light, pname, param);
        }

        public void Lightfv(uint light, uint pname, float[] @params) {
            OpenGL.GlLightfv(light, pname, @params);
        }

        public void Lighti(uint light, uint pname, int param) {
            OpenGL.GlLighti(light, pname, param);
        }

        public void Lightiv(uint light, uint pname, int[] @params) {
            OpenGL.GlLightiv(light, pname, @params);
        }

        public void LineStipple(int factor, ushort pattern) {
            OpenGL.GlLineStipple(factor, pattern);
        }

        public void LineWidth(float width) {
            OpenGL.GlLineWidth(width);
        }

        public void ListBase(uint @base) {
            OpenGL.GlListBase(@base);
        }

        public void LoadIdentity() {
            OpenGL.GlLoadIdentity();
        }

        public void LoadMatrixd(double[] m) {
            OpenGL.GlLoadMatrixd( m);
        }

        public void LoadMatrixf(float[] m) {
            OpenGL.GlLoadMatrixf( m);
        }

        public void LoadName(uint name) {
            OpenGL.GlLoadName(name);
        }

        public void LogicOp(uint opcode) {
            OpenGL.GlLogicOp(opcode);
        }

        public void Map1d(uint target, double u1, double u2, int stride, int order, double[] points) {
            OpenGL.GlMap1d(target, u1, u2, stride, order, points);
        }

        public void Map1f(uint target, float u1, float u2, int stride, int order, float[] points) {
            OpenGL.GlMap1f(target, u1, u2, stride, order, points);
        }

        public void Map2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points) {
            OpenGL.GlMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }

        public void Map2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points) {
            OpenGL.GlMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
        }

        public void MapGrid1d(int un, double u1, double u2) {
            OpenGL.GlMapGrid1d(un, u1, u2);
        }

        public void MapGrid1f(int un, float u1, float u2) {
            OpenGL.GlMapGrid1f(un, u1, u2);
        }

        public void MapGrid2d(int un, double u1, double u2, int vn, double v1, double v2) {
            OpenGL.GlMapGrid2d(un, u1, u2, vn, v1, v2);
        }

        public void MapGrid2f(int un, float u1, float u2, int vn, float v1, float v2) {
            OpenGL.GlMapGrid2f(un, u1, u2, vn, v1, v2);
        }

        public void Materialf(uint face, uint pname, float param) {
            OpenGL.GlMaterialf(face, pname, param);
        }

        public void Materialfv(uint face, uint pname, float[] @params) {
            OpenGL.GlMaterialfv(face, pname, @params);
        }

        public void Materiali(uint face, uint pname, int param) {
            OpenGL.GlMateriali(face, pname, param);
        }

        public void Materialiv(uint face, uint pname, int[] @params) {
            OpenGL.GlMaterialiv(face, pname, @params);
        }

        public void MatrixMode(uint mode) {
            OpenGL.GlMatrixMode(mode);
        }

        public void MultMatrixd(double[] m) {
            OpenGL.GlMultMatrixd( m);
        }

        public void MultMatrixf(float[] m) {
            OpenGL.GlMultMatrixf( m);
        }

        public void NewList(uint list, uint mode) {
            OpenGL.GlNewList(list, mode);
        }

        public void Normal3b(sbyte nx, sbyte ny, sbyte nz) {
            OpenGL.GlNormal3b(nx, ny, nz);
        }

        public void Normal3d(double nx, double ny, double nz) {
            OpenGL.GlNormal3d(nx, ny, nz);
        }

        public void Normal3dv(double[] v) {
            OpenGL.GlNormal3dv( v);
        }

        public void Normal3f(float nx, float ny, float nz) {
            OpenGL.GlNormal3f(nx, ny, nz);
        }

        public void Normal3fv(float[] v) {
            OpenGL.GlNormal3fv( v);
        }

        public void Normal3i(int nx, int ny, int nz) {
            OpenGL.GlNormal3i(nx, ny, nz);
        }

        public void Normal3iv(int[] v) {
            OpenGL.GlNormal3iv( v);
        }

        public void Normal3s(short nx, short ny, short nz) {
            OpenGL.GlNormal3s(nx, ny, nz);
        }

        public void Normal3sv(short[] v) {
            OpenGL.GlNormal3sv( v);
        }

        public void NormalPointer(uint type, int stride, IntPtr pointer) {
            OpenGL.GlNormalPointer(type, stride, pointer);
        }

        public void Ortho(double left, double right, double bottom, double top, double zNear, double zFar) {
            OpenGL.GlOrtho(left, right, bottom, top, zNear, zFar);
        }

        public void PassThrough(float token) {
            OpenGL.GlPassThrough(token);
        }

        public void PixelMapfv(uint map, int mapsize, float[] values) {
            OpenGL.GlPixelMapfv(map, mapsize, values);
        }

        public void PixelMapuiv(uint map, int mapsize, uint[] values) {
            OpenGL.GlPixelMapuiv(map, mapsize, values);
        }

        public void PixelMapusv(uint map, int mapsize, ushort[] values) {
            OpenGL.GlPixelMapusv(map, mapsize, values);
        }

        public void PixelStoref(uint pname, float param) {
            OpenGL.GlPixelStoref(pname, param);
        }

        public void PixelStorei(uint pname, int param) {
            OpenGL.GlPixelStorei(pname, param);
        }

        public void PixelTransferf(uint pname, float param) {
            OpenGL.GlPixelTransferf(pname, param);
        }

        public void PixelTransferi(uint pname, int param) {
            OpenGL.GlPixelTransferi(pname, param);
        }

        public void PixelZoom(float xfactor, float yfactor) {
            OpenGL.GlPixelZoom(xfactor, yfactor);
        }

        public void PointSize(float size) {
            OpenGL.GlPointSize(size);
        }

        public void PolygonMode(uint face, uint mode) {
            OpenGL.GlPolygonMode(face, mode);
        }

        public void PolygonOffset(float factor, float units) {
            OpenGL.GlPolygonOffset(factor, units);
        }

        public void PopAttrib() {
            OpenGL.GlPopAttrib();
        }

        public void PopClientAttrib() {
            OpenGL.GlPopClientAttrib();
        }

        public void PopMatrix() {
            OpenGL.GlPopMatrix();
        }

        public void PopName() {
            OpenGL.GlPopName();
        }

        public void PrioritizeTextures(int n, uint[] textures, float[] priorities) {
            OpenGL.GlPrioritizeTextures(n, textures, priorities);
        }

        public void PushAttrib(uint mask) {
            OpenGL.GlPushAttrib(mask);
        }

        public void PushClientAttrib(uint mask) {
            OpenGL.GlPushClientAttrib(mask);
        }

        public void PushMatrix() {
            OpenGL.GlPushMatrix();
        }

        public void PushName(uint name) {
            OpenGL.GlPushName(name);
        }

        public void RasterPos2d(double x, double y) {
            OpenGL.GlRasterPos2d(x, y);
        }

        public void RasterPos2dv(double[] v) {
            OpenGL.GlRasterPos2dv( v);
        }

        public void RasterPos2f(float x, float y) {
            OpenGL.GlRasterPos2f(x, y);
        }

        public void RasterPos2fv(float[] v) {
            OpenGL.GlRasterPos2fv( v);
        }

        public void RasterPos2i(int x, int y) {
            OpenGL.GlRasterPos2i(x, y);
        }

        public void RasterPos2iv(int[] v) {
            OpenGL.GlRasterPos2iv( v);
        }

        public void RasterPos2s(short x, short y) {
            OpenGL.GlRasterPos2s(x, y);
        }

        public void RasterPos2sv(short[] v) {
            OpenGL.GlRasterPos2sv( v);
        }

        public void RasterPos3d(double x, double y, double z) {
            OpenGL.GlRasterPos3d(x, y, z);
        }

        public void RasterPos3dv(double[] v) {
            OpenGL.GlRasterPos3dv( v);
        }

        public void RasterPos3f(float x, float y, float z) {
            OpenGL.GlRasterPos3f(x, y, z);
        }

        public void RasterPos3fv(float[] v) {
            OpenGL.GlRasterPos3fv( v);
        }

        public void RasterPos3i(int x, int y, int z) {
            OpenGL.GlRasterPos3i(x, y, z);
        }

        public void RasterPos3iv(int[] v) {
            OpenGL.GlRasterPos3iv( v);
        }

        public void RasterPos3s(short x, short y, short z) {
            OpenGL.GlRasterPos3s(x, y, z);
        }

        public void RasterPos3sv(short[] v) {
            OpenGL.GlRasterPos3sv( v);
        }

        public void RasterPos4d(double x, double y, double z, double w) {
            OpenGL.GlRasterPos4d(x, y, z, w);
        }

        public void RasterPos4dv(double[] v) {
            OpenGL.GlRasterPos4dv( v);
        }

        public void RasterPos4f(float x, float y, float z, float w) {
            OpenGL.GlRasterPos4f(x, y, z, w);
        }

        public void RasterPos4fv(float[] v) {
            OpenGL.GlRasterPos4fv( v);
        }

        public void RasterPos4i(int x, int y, int z, int w) {
            OpenGL.GlRasterPos4i(x, y, z, w);
        }

        public void RasterPos4iv(int[] v) {
            OpenGL.GlRasterPos4iv( v);
        }

        public void RasterPos4s(short x, short y, short z, short w) {
            OpenGL.GlRasterPos4s(x, y, z, w);
        }

        public void RasterPos4sv(short[] v) {
            OpenGL.GlRasterPos4sv( v);
        }

        public void ReadBuffer(uint mode) {
            OpenGL.GlReadBuffer(mode);
        }

        public void ReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels) {
            OpenGL.GlReadPixels(x, y, width, height, format, type, pixels);
        }

        public void Rectd(double x1, double y1, double x2, double y2) {
            OpenGL.GlRectd(x1, y1, x2, y2);
        }

        public void Rectdv(double[] v1, double[] v2) {
            OpenGL.GlRectdv(v1, v2);
        }

        public void Rectf(float x1, float y1, float x2, float y2) {
            OpenGL.GlRectf(x1, y1, x2, y2);
        }

        public void Rectfv(float[] v1, float[] v2) {
            OpenGL.GlRectfv(v1, v2);
        }

        public void Recti(int x1, int y1, int x2, int y2) {
            OpenGL.GlRecti(x1, y1, x2, y2);
        }

        public void Rectiv(int[] v1, int[] v2) {
            OpenGL.GlRectiv(v1, v2);
        }

        public void Rects(short x1, short y1, short x2, short y2) {
            OpenGL.GlRects(x1, y1, x2, y2);
        }

        public void Rectsv(short[] v1, short[] v2) {
            OpenGL.GlRectsv(v1, v2);
        }

        public int RenderMode(uint mode) {
            return OpenGL.GlRenderMode(mode);
        }

        public void Rotated(double angle, double x, double y, double z) {
            OpenGL.GlRotated(angle, x, y, z);
        }

        public void Rotatef(float angle, float x, float y, float z) {
            OpenGL.GlRotatef(angle, x, y, z);
        }

        public void Scaled(double x, double y, double z) {
            OpenGL.GlScaled(x, y, z);
        }

        public void Scalef(float x, float y, float z) {
            OpenGL.GlScalef(x, y, z);
        }

        public void Scissor(int x, int y, int width, int height) {
            OpenGL.GlScissor(x, y, width, height);
        }

        public void SelectBuffer(int size, uint[] buffer) {
            OpenGL.GlSelectBuffer(size, buffer);
        }

        public void ShadeModel(uint mode) {
            OpenGL.GlShadeModel(mode);
        }

        public void StencilFunc(uint func, int @ref, uint mask) {
            OpenGL.GlStencilFunc(func, @ref, mask);
        }

        public void StencilMask(uint mask) {
            OpenGL.GlStencilMask(mask);
        }

        public void StencilOp(uint fail, uint zfail, uint zpass) {
            OpenGL.GlStencilOp(fail, zfail, zpass);
        }

        public void TexCoord1d(double s) {
            OpenGL.GlTexCoord1d(s);
        }

        public void TexCoord1dv(double[] v) {
            OpenGL.GlTexCoord1dv( v);
        }

        public void TexCoord1f(float s) {
            OpenGL.GlTexCoord1f(s);
        }

        public void TexCoord1fv(float[] v) {
            OpenGL.GlTexCoord1fv( v);
        }

        public void TexCoord1i(int s) {
            OpenGL.GlTexCoord1i(s);
        }

        public void TexCoord1iv(int[] v) {
            OpenGL.GlTexCoord1iv( v);
        }

        public void TexCoord1s(short s) {
            OpenGL.GlTexCoord1s(s);
        }

        public void TexCoord1sv(short[] v) {
            OpenGL.GlTexCoord1sv( v);
        }

        public void TexCoord2d(double s, double t) {
            OpenGL.GlTexCoord2d(s, t);
        }

        public void TexCoord2dv(double[] v) {
            OpenGL.GlTexCoord2dv( v);
        }

        public void TexCoord2f(float s, float t) {
            OpenGL.GlTexCoord2f(s, t);
        }

        public void TexCoord2fv(float[] v) {
            OpenGL.GlTexCoord2fv( v);
        }

        public void TexCoord2i(int s, int t) {
            OpenGL.GlTexCoord2i(s, t);
        }

        public void TexCoord2iv(int[] v) {
            OpenGL.GlTexCoord2iv( v);
        }

        public void TexCoord2s(short s, short t) {
            OpenGL.GlTexCoord2s(s, t);
        }

        public void TexCoord2sv(short[] v) {
            OpenGL.GlTexCoord2sv( v);
        }

        public void TexCoord3d(double s, double t, double r) {
            OpenGL.GlTexCoord3d(s, t, r);
        }

        public void TexCoord3dv(double[] v) {
            OpenGL.GlTexCoord3dv( v);
        }

        public void TexCoord3f(float s, float t, float r) {
            OpenGL.GlTexCoord3f(s, t, r);
        }

        public void TexCoord3fv(float[] v) {
            OpenGL.GlTexCoord3fv( v);
        }

        public void TexCoord3i(int s, int t, int r) {
            OpenGL.GlTexCoord3i(s, t, r);
        }

        public void TexCoord3iv(int[] v) {
            OpenGL.GlTexCoord3iv( v);
        }

        public void TexCoord3s(short s, short t, short r) {
            OpenGL.GlTexCoord3s(s, t, r);
        }

        public void TexCoord3sv(short[] v) {
            OpenGL.GlTexCoord3sv( v);
        }

        public void TexCoord4d(double s, double t, double r, double q) {
            OpenGL.GlTexCoord4d(s, t, r, q);
        }

        public void TexCoord4dv(double[] v) {
            OpenGL.GlTexCoord4dv( v);
        }

        public void TexCoord4f(float s, float t, float r, float q) {
            OpenGL.GlTexCoord4f(s, t, r, q);
        }

        public void TexCoord4fv(float[] v) {
            OpenGL.GlTexCoord4fv( v);
        }

        public void TexCoord4i(int s, int t, int r, int q) {
            OpenGL.GlTexCoord4i(s, t, r, q);
        }

        public void TexCoord4iv(int[] v) {
            OpenGL.GlTexCoord4iv( v);
        }

        public void TexCoord4s(short s, short t, short r, short q) {
            OpenGL.GlTexCoord4s(s, t, r, q);
        }

        public void TexCoord4sv(short[] v) {
            OpenGL.GlTexCoord4sv( v);
        }

        public void TexCoordPointer(int size, uint type, int stride, IntPtr pointer) {
            OpenGL.GlTexCoordPointer(size, type, stride, pointer);
        }

        public void TexEnvf(uint target, uint pname, float param) {
            OpenGL.GlTexEnvf(target, pname, param);
        }

        public void TexEnvfv(uint target, uint pname, float[] @params) {
            OpenGL.GlTexEnvfv(target, pname, @params);
        }

        public void TexEnvi(uint target, uint pname, int param) {
            OpenGL.GlTexEnvi(target, pname, param);
        }

        public void TexEnviv(uint target, uint pname, int[] @params) {
            OpenGL.GlTexEnviv(target, pname, @params);
        }

        public void TexGend(uint coord, uint pname, double param) {
            OpenGL.GlTexGend(coord, pname, param);
        }

        public void TexGendv(uint coord, uint pname, double[] @params) {
            OpenGL.GlTexGendv(coord, pname, @params);
        }

        public void TexGenf(uint coord, uint pname, float param) {
            OpenGL.GlTexGenf(coord, pname, param);
        }

        public void TexGenfv(uint coord, uint pname, float[] @params) {
            OpenGL.GlTexGenfv(coord, pname, @params);
        }

        public void TexGeni(uint coord, uint pname, int param) {
            OpenGL.GlTexGeni(coord, pname, param);
        }

        public void TexGeniv(uint coord, uint pname, int[] @params) {
            OpenGL.GlTexGeniv(coord, pname, @params);
        }

        public void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels) {
            OpenGL.GlTexImage1D(target, level, internalformat, width, border, format, type, pixels);
        }

        public void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels) {
            OpenGL.GlTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
        }

        public void TexParameterf(uint target, uint pname, float param) {
            OpenGL.GlTexParameterf(target, pname, param);
        }

        public void TexParameterfv(uint target, uint pname, float[] @params) {
            OpenGL.GlTexParameterfv(target, pname, @params);
        }

        public void TexParameteri(uint target, uint pname, int param) {
            OpenGL.GlTexParameteri(target, pname, param);
        }

        public void TexParameteriv(uint target, uint pname, int[] @params) {
            OpenGL.GlTexParameteriv(target, pname, @params);
        }

        public void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels) {
            OpenGL.GlTexSubImage1D(target, level, xoffset, width, format, type, pixels);
        }

        public void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels) {
            OpenGL.GlTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        public void Translated(double x, double y, double z) {
            OpenGL.GlTranslated(x, y, z);
        }

        public void Translatef(float x, float y, float z) {
            OpenGL.GlTranslatef(x, y, z);
        }

        public void Vertex2d(double x, double y) {
            OpenGL.GlVertex2d(x, y);
        }

        public void Vertex2dv(double[] v) {
            OpenGL.GlVertex2dv( v);
        }

        public void Vertex2f(float x, float y) {
            OpenGL.GlVertex2f(x, y);
        }

        public void Vertex2fv(float[] v) {
            OpenGL.GlVertex2fv( v);
        }

        public void Vertex2i(int x, int y) {
            OpenGL.GlVertex2i(x, y);
        }

        public void Vertex2iv(int[] v) {
            OpenGL.GlVertex2iv( v);
        }

        public void Vertex2s(short x, short y) {
            OpenGL.GlVertex2s(x, y);
        }

        public void Vertex2sv(short[] v) {
            OpenGL.GlVertex2sv( v);
        }

        public void Vertex3d(double x, double y, double z) {
            OpenGL.GlVertex3d(x, y, z);
        }

        public void Vertex3dv(double[] v) {
            OpenGL.GlVertex3dv( v);
        }

        public void Vertex3f(float x, float y, float z) {
            OpenGL.GlVertex3f(x, y, z);
        }

        public void Vertex3fv(float[] v) {
            OpenGL.GlVertex3fv( v);
        }

        public void Vertex3i(int x, int y, int z) {
            OpenGL.GlVertex3i(x, y, z);
        }

        public void Vertex3iv(int[] v) {
            OpenGL.GlVertex3iv( v);
        }

        public void Vertex3s(short x, short y, short z) {
            OpenGL.GlVertex3s(x, y, z);
        }

        public void Vertex3sv(short[] v) {
            OpenGL.GlVertex3sv( v);
        }

        public void Vertex4d(double x, double y, double z, double w) {
            OpenGL.GlVertex4d(x, y, z, w);
        }

        public void Vertex4dv(double[] v) {
            OpenGL.GlVertex4dv( v);
        }

        public void Vertex4f(float x, float y, float z, float w) {
            OpenGL.GlVertex4f(x, y, z, w);
        }

        public void Vertex4fv(float[] v) {
            OpenGL.GlVertex4fv( v);
        }

        public void Vertex4i(int x, int y, int z, int w) {
            OpenGL.GlVertex4i(x, y, z, w);
        }

        public void Vertex4iv(int[] v) {
            OpenGL.GlVertex4iv( v);
        }

        public void Vertex4s(short x, short y, short z, short w) {
            OpenGL.GlVertex4s(x, y, z, w);
        }

        public void Vertex4sv(short[] v) {
            OpenGL.GlVertex4sv( v);
        }

        public void VertexPointer(int size, uint type, int stride, IntPtr pointer) {
            OpenGL.GlVertexPointer(size, type, stride, pointer);
        }

        public void Viewport(int x, int y, int width, int height) {
            OpenGL.GlViewport(x, y, width, height);
        }

        public unsafe byte AreTexturesResident(int n, uint[] textures, byte[] residences) {
            fixed (byte *pResidences = residences) {
                return OpenGL.GlAreTexturesResident(n, textures, pResidences);
            }
        }

        public unsafe void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap) {
            fixed (byte *pBitmap = bitmap) {
                OpenGL.GlBitmap(width, height, xorig, yorig, xmove, ymove, pBitmap);
            }
        }

        public unsafe void Color3bv(sbyte[] v) {
            fixed (sbyte *pv = v) {
                OpenGL.GlColor3bv(pv);
            }
        }

        public unsafe void Color3ubv(byte[] v) {
            fixed (byte *pv = v) {
                OpenGL.GlColor3ubv(pv);
            }
        }

        public unsafe void Color4bv(sbyte[] v) {
            fixed (sbyte *pv = v) {
                OpenGL.GlColor4bv(pv);
            }
        }

        public unsafe void Color4ubv(byte[] v) {
            fixed (byte *pv = v) {
                OpenGL.GlColor4ubv(pv);
            }
        }

        public unsafe void EdgeFlagv(byte[] flag) {
            fixed (byte *pFlag = flag) {
                OpenGL.GlEdgeFlagv(pFlag);
            }
        }

        public unsafe void GetBooleanv(uint pname, byte[] @params) {
            fixed (byte *pParams = @params) {
                OpenGL.GlGetBooleanv(pname, pParams);
            }
        }

        private unsafe void GetPointerv(uint pname, byte[][] @params, void **ptr, int i) {
            fixed (byte *pParams = @params[i]) {
                ptr[i] = pParams;
                if (++i == @params.Length) {
                    OpenGL.GlGetPointerv(pname, ptr);
                } else {
                    GetPointerv(pname, @params, ptr, i);
                }
            }
        }

        public unsafe void GetPointerv(uint pname, byte[][] @params) {
            IntPtr ptr = Marshal.AllocHGlobal(@params.Length * sizeof(void *));
            try {
                GetPointerv(pname, @params, (void **) ptr.ToPointer(), 0);
            } finally {
                Marshal.FreeHGlobal(ptr);
            }
        }

        public unsafe void GetPolygonStipple(byte[] mask) {
            fixed (byte *pMask = mask) {
                OpenGL.GlGetPolygonStipple(pMask);
            }
        }

        public unsafe string GetString(uint name) {
            byte *s = OpenGL.GlGetString(name);
            IntPtr ptr = new IntPtr(s);
            return Marshal.PtrToStringUni(ptr);
        }

        public unsafe void Indexubv(byte[] c) {
            fixed (byte *pc = c) {
                OpenGL.GlIndexubv(pc);
            }
        }

        public unsafe void Normal3bv(sbyte[] v) {
            fixed (sbyte *pv = v) {
                OpenGL.GlNormal3bv(pv);
            }
        }

        public unsafe void PolygonStipple(byte[] mask) {
            fixed (byte *pMask = mask) {
                OpenGL.GlPolygonStipple(pMask);
            }
        }
#endregion
    }
}
