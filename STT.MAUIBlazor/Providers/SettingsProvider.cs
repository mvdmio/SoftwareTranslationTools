using STT.MAUIBlazor.Data;

namespace STT.MAUIBlazor.Providers;

public class SettingsProvider
{
   public async Task<SettingsData> Retrieve()
   {
      return new SettingsData();
   }

   public void Save(SettingsData settingsData)
   {
   }
}