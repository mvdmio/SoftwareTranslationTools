using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using STT.WPF.Core;
using STT.WPF.Services;

namespace STT.WPF.Pages;

public partial class SettingsPage : UserControl
{
    public SettingsPage()
    {
        InitializeComponent();
    }
}

public partial class SettingsPageViewModel : ViewModelBase
{
    [ObservableProperty]
    private NavigationService _navigationService;

    public SettingsPageViewModel(NavigationService navigationService)
    {
        _navigationService = navigationService;
    }
    
    [RelayCommand]
    private void NavigateToTranslationPage()
    {
        NavigationService.NavigateTo<TranslationPageViewModel>();
    }
}