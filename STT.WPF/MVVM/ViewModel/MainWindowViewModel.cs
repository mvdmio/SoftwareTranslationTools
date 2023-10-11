using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using STT.WPF.MVVM.Core;
using STT.WPF.Services;

namespace STT.WPF.MVVM.ViewModel;

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
    public void ToggleSettingsPage()
    {
        if (NavigationService.CurrentView is SettingsPageViewModel)
            NavigateToTranslationPage();
        else
            NavigateToSettingsPage();
    }
    
    [RelayCommand]
    public void NavigateToTranslationPage()
    {
        NavigationService.NavigateTo<TranslationPageViewModel>();
    }

    [RelayCommand]
    public void NavigateToSettingsPage()
    {
        NavigationService.NavigateTo<SettingsPageViewModel>();
    }
}