using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using STT.WPF.MVVM.ViewModel;
using STT.WPF.Services;

namespace STT.WPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
   private readonly ServiceProvider _serviceProvider;

   public App()
   {
      var services = new ServiceCollection();
      
      services.AddSingleton<MainWindowViewModel>();
      services.AddSingleton<TranslationPageViewModel>();
      services.AddSingleton<SettingsPageViewModel>();

      services.AddSingleton<MainWindow>(p => new MainWindow {
         DataContext = p.GetRequiredService<MainWindowViewModel>()
      });

      services.AddSingleton<NavigationService>(p => new NavigationService(p));
       
      _serviceProvider = services.BuildServiceProvider();
   }

   protected override void OnStartup(StartupEventArgs e)
   {
      base.OnStartup(e);

      var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
      mainWindow.Show();
   }
}