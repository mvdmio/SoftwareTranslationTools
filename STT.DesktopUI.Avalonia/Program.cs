using Avalonia;
using Avalonia.ReactiveUI;
using System;
using Avalonia.Svg;
using Splat;

namespace STT.DesktopUI.Avalonia;

class Program
{
   // Initialization code. Don't use any Avalonia, third-party APIs or any
   // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
   // yet and stuff might break.
   [STAThread]
   public static void Main(string[] args)
   {
      RegisterServices(Locator.CurrentMutable, Locator.Current);
      BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
   }

   // Avalonia configuration, don't remove; also used by visual designer.
   public static AppBuilder BuildAvaloniaApp()
   {
      GC.KeepAlive(typeof(SvgImageExtension).Assembly);

      
      return AppBuilder.Configure<App>().UsePlatformDetect().WithInterFont().LogToTrace().UseReactiveUI();
   }

   private static void RegisterServices(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
   {
   }
}