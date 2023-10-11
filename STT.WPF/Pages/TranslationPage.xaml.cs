using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using STT.WPF.Core;
using STT.WPF.Services;

namespace STT.WPF.Pages;

public partial class TranslationPage : UserControl
{
    public TranslationPage()
    {
        InitializeComponent();
    }
}

public partial class TranslationPageViewModel : ViewModelBase
{
    [ObservableProperty]
    private NavigationService _navigationService;

    public TranslationPageViewModel(NavigationService navigationService)
    {
        _navigationService = navigationService;
    }
    
    [RelayCommand]
    private void NavigateToSettingsPage()
    {
        NavigationService.NavigateTo<SettingsPageViewModel>();
    }
}