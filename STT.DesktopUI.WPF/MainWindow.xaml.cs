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
        _navigationService.NavigateTo<TranslationPageViewModel>();
    }
}