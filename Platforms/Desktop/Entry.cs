using System;
using System.Reflection;
using System.Runtime.Loader;

namespace Com.GitHub.ZachDeibert.GraphicsCore.Platforms.Desktop {
    static class Entry {
        static void Main(string[] args) {
            try {
                NativeLoadContext ctx = new NativeLoadContext();
                Assembly asm = ctx.LoadFromAssemblyName(typeof(Entry).GetTypeInfo().Assembly.GetName());
                Type cls = asm.GetType(typeof(RenderContextFactory).FullName);
                ConstructorInfo ctor = cls.GetConstructor(new Type[0]);
                ApplicationSetup.Run((IRenderContextFactory) ctor.Invoke(new object[0]));
            } catch (Exception ex) {
                Console.Error.WriteLine(ex);
            }
        }
    }
}
