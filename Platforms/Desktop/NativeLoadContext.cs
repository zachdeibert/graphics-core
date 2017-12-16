using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop {
    class NativeLoadContext : AssemblyLoadContext {
        static readonly string BaseDir = Path.GetDirectoryName(typeof(NativeLoadContext).GetTypeInfo().Assembly.CodeBase.Substring(5));
        static readonly string[] LibraryDirs = new string[] {
            "/lib",
            "/lib32",
            "/lib64",
            "/usr/lib",
            "/usr/lib32",
            "/usr/lib64",
            "/usr/local/lib",
            "/usr/local/lib32",
            "/usr/local/lib64",
            BaseDir
        };

        protected override Assembly Load(AssemblyName assemblyName) {
            string name = Path.Combine(BaseDir, string.Concat(assemblyName.Name, ".dll"));
            if (File.Exists(name)) {
                return LoadFromAssemblyPath(name);
            } else {
                return null;
            }
        }

        IntPtr LoadFromNameUnix(string name) {
            foreach (string dir in LibraryDirs) {
                string file = Path.Combine(dir, name);
                if (File.Exists(file)) {
                    return LoadUnmanagedDllFromPath(file);
                } else foreach (string subdir in Directory.GetDirectories(dir, "*-*-*")) {
                    file = Path.Combine(subdir, name);
                    if (File.Exists(file)) {
                        return LoadUnmanagedDllFromPath(file);
                    }
                }
            }
            throw new DllNotFoundException(name);
        }

        IntPtr LoadFromNameWindows(string name) {
            string file;
            foreach (string dir in Environment.GetEnvironmentVariable("PATH").Split(';')) {
                file = Path.Combine(dir, name);
                if (File.Exists(file)) {
                    return LoadUnmanagedDllFromPath(file);
                }
            }
            file = Path.Combine(BaseDir, name);
            if (File.Exists(file)) {
                return LoadUnmanagedDllFromPath(file);
            }
            throw new DllNotFoundException(name);
        }

        protected override IntPtr LoadUnmanagedDll(string unmanagedDllName) {
            switch (unmanagedDllName) {
                case "glfw3":
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                        return LoadFromNameWindows("libglfw.dll");
                    } else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                        return LoadFromNameUnix("libglfw.dylib");
                    } else {
                        return LoadFromNameUnix("libglfw.so.3");
                    }
                case "OpenGL32":
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                        return LoadFromNameWindows("opengl32.dll");
                    } else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                        return LoadUnmanagedDllFromPath("/System/Library/Frameworks/OpenGL.framework/Libraries/libGL.dylib");
                    } else {
                        return LoadFromNameUnix("libGL.so");
                    }
                default:
                    throw new DllNotFoundException(unmanagedDllName);
            }
        }
    }
}
