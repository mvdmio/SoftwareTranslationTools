using System.Diagnostics.CodeAnalysis;
using CommunityToolkit.Mvvm.ComponentModel;

namespace STT.WPF.ViewModel;

public class MainWindowViewModel : ObservableObject
{
    private readonly TranslationPageViewModel _translationPageViewModel;
    private readonly SettingsPageViewModel _settingsPageViewModel;

    private object _currentView;

    public object CurrentView
    {
        get => _currentView;
        [MemberNotNull(nameof(_currentView))]
        set => SetProperty(ref _currentView, value);
    }

    public MainWindowViewModel()
    {
        _translationPageViewModel = new TranslationPageViewModel();
        _settingsPageViewModel = new SettingsPageViewModel();

        _currentView = _translationPageViewModel;
    }

    public void NavigateToTranslationPage()
    {
        CurrentView = _translationPageViewModel;
    }

    public void NavigateToSettingsPage()
    {
        CurrentView = _settingsPageViewModel;
    }
}