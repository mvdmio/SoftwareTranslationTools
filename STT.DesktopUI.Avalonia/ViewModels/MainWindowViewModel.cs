using ReactiveUI;
using STT.DesktopUI.Avalonia.ViewModels.Base;

namespace STT.DesktopUI.Avalonia.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
   private ViewModelBase _contentViewModel = ViewModelFactory.TranslationOverview;

   public ViewModelBase ContentViewModel
   {
      get => _contentViewModel;
      set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
   }

   public void ToggleSettings()
   {
      if(ContentViewModel is SettingsViewModel)
         NavigateToTranslationOverview();
      else
         NavigateToSettings();
   }

   public void NavigateToTranslationOverview()
   {
      ContentViewModel = ViewModelFactory.TranslationOverview;
   }

   public void NavigateToSettings()
   {
      ContentViewModel = ViewModelFactory.Settings;
   }
}
