using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Platform.Storage;
using STT.DesktopUI.Avalonia.ViewModels;

namespace STT.DesktopUI.Avalonia.Views;

public partial class SettingsView : UserControl
{
   private IStorageProvider _storageProvider;
   private SettingsViewModel _viewModel;

   public SettingsView()
   {
      InitializeComponent();
   }

   protected override void OnInitialized()
   {
      base.OnInitialized();
      
      _viewModel = (SettingsViewModel)DataContext!;
      _storageProvider = TopLevel.GetTopLevel(this)!.StorageProvider;
   }

   private async void RootPath_BrowseButton_Click(object? sender, RoutedEventArgs e)
   {
      if(!_storageProvider.CanOpen || !_storageProvider.CanPickFolder)
         return;

      var folder = await _storageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions {
         Title = "Root Path",
         AllowMultiple = false
      });

      _viewModel.RootPath = folder.Count == 0 ? string.Empty : folder[0].Path.AbsolutePath;
   }

   private void Close_Settings_Click(object? sender, RoutedEventArgs e)
   {
      ((MainWindowViewModel)Parent!.DataContext!).NavigateToTranslationOverview();
   }
}