using System.Windows;

namespace STT.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NavigateToTranslationPage();
        }

        private void NavigateToTranslationPage()
        {
            ContentFrame.Navigate(new TranslationPage());
        }

        private void NavigateToSettingsPage()
        {
            ContentFrame.Navigate(new SettingsPage());
        }

        private void SettingsButton_OnClick(object sender, RoutedEventArgs e)
        {
            NavigateToSettingsPage();
        }
    }
}