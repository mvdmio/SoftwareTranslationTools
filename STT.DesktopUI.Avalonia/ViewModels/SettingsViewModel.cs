using ReactiveUI;
using STT.DesktopUI.Avalonia.ViewModels.Base;

namespace STT.DesktopUI.Avalonia.ViewModels;

public class SettingsViewModel : ViewModelBase
{
   private string _rootPath = string.Empty;

   public string RootPath 
   { 
      get => _rootPath;
      set => this.RaiseAndSetIfChanged(ref _rootPath, value);
   }
}
