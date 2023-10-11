using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using STT.WPF.Core;
using STT.WPF.Pages;
using STT.WPF.Services;

namespace STT.WPF;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
}

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private NavigationService _navigationService;

    public MainWindowViewModel(NavigationService navigationService)
    {
        _navigationService = navigationService;
        
        NavigateToTranslationPage();
    }

    [RelayCommand]
    private void ToggleSettingsPage()
    {
        if (NavigationService.CurrentView is SettingsPageViewModel)
            NavigateToTranslationPage();
        else
            NavigateToSettingsPage();
    }
    
    [RelayCommand]
    private void NavigateToTranslationPage()
    {
        NavigationService.NavigateTo<TranslationPageViewModel>();
    }

    [RelayCommand]
    private void NavigateToSettingsPage()
    {
        NavigationService.NavigateTo<SettingsPageViewModel>();
    }
}