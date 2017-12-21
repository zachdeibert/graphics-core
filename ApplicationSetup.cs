using System;
using System.Linq;
using System.Reflection;

namespace Com.GitHub.ZachDeibert.GraphicsCore {
    internal static class ApplicationSetup {
        internal static void Run(IRenderContextFactory factory, Assembly asm) {
            TypeInfo[] types = asm.ExportedTypes.Select(t => t.GetTypeInfo()).Where(t => t.GetCustomAttribute<ApplicationAttribute>() != null).ToArray();
            switch (types.Length) {
                case 0:
                    Console.Error.WriteLine("Please annotate a class with [Application].");
                    Environment.Exit(1);
                    break;
                case 1:
                    object appObj = types[0].GetConstructor(new Type[0]).Invoke(new object[0]);
                    if (!(appObj is IApplication)) {
                        Console.WriteLine("Application needs to be upgraded");
                    }
                    if (appObj is IApplication) {
                        IApplication app = (IApplication) appObj;
                        ApplicationType type = app.Type;
                        if (factory.SupportsApplication(type)) {
                            IRenderContext ctx = factory.CreateContext(type, app.Name);
                            app.Start(ctx);
                            ctx.ShuttingDown += app.Stop;
                            if (ctx is IRenderContextInternal) {
                                ((IRenderContextInternal) ctx).Start();
                            }
                        } else {
                            Console.Error.WriteLine("Unable to create render context for application because it is not supported on this platform.");
                        }
                    }
                    break;
                default:
                    Console.Error.WriteLine("Please only annotate one class with [Application].");
                    Environment.Exit(1);
                    break;
            }
        }
    }
}
