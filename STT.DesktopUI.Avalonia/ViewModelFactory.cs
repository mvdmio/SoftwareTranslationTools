using STT.DesktopUI.Avalonia.ViewModels;

namespace STT.DesktopUI.Avalonia;

public static class ViewModelFactory
{
   private static TranslationOverviewViewModel? translationOverview;
   private static SettingsViewModel? settings;

   public static SettingsViewModel Settings
   {
      get
      {
         if(settings is null)
            settings = new SettingsViewModel();

         return settings;
      }
   }

   public static TranslationOverviewViewModel TranslationOverview
   {
      get
      {
         if(translationOverview is null)
            translationOverview = new TranslationOverviewViewModel();

         return translationOverview;
      }
   }
}