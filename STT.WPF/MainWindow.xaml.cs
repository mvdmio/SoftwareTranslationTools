using System.Windows;
using STT.WPF.ViewModel;

namespace STT.WPF;

public partial class MainWindow : Window
{
    private readonly MainWindowViewModel _viewModel;

    public MainWindow()
    {
        DataContext = _viewModel = new MainWindowViewModel();
        _viewModel.NavigateToTranslationPage();

        InitializeComponent();
    }

    private void SettingsButton_OnClick(object sender, RoutedEventArgs e)
    {
        _viewModel.NavigateToSettingsPage();
    }
}