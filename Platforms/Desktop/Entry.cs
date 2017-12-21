using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop {
    static class Entry {
        static void Main(string[] args) {
            try {
                NativeLoadContext ctx = new NativeLoadContext();
                Assembly GraphicsCore_Platforms_Desktop = ctx.LoadFromAssemblyName(typeof(Entry).GetTypeInfo().Assembly.GetName());
                Type RenderContextFactory = GraphicsCore_Platforms_Desktop.GetType(typeof(RenderContextFactory).FullName);
                ConstructorInfo ctor = RenderContextFactory.GetConstructor(new Type[0]);
                Assembly GraphicsCore = ctx.LoadFromAssemblyName(typeof(ApplicationSetup).GetTypeInfo().Assembly.GetName());
                Type ApplicationSetup = GraphicsCore.GetType(typeof(ApplicationSetup).FullName);
                MethodInfo Run = ApplicationSetup.GetMethod("Run", BindingFlags.NonPublic | BindingFlags.Static);
                UriBuilder uri = new UriBuilder(GraphicsCore.CodeBase);
                Assembly GraphicsCore_Application = ctx.LoadFromAssemblyPath(Path.Combine(Path.GetDirectoryName(Uri.UnescapeDataString(uri.Path)), "GraphicsCore.Application.dll"));
                Run.Invoke(null, new object[] {
                    ctor.Invoke(new object[0]),
                    GraphicsCore_Application
                });
            } catch (Exception ex) {
                Console.Error.WriteLine(ex);
            }
        }
    }
}
