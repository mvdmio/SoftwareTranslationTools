using CommunityToolkit.Mvvm.ComponentModel;

namespace STT.WPF.ViewModel;

public partial class TextInputViewModel : ObservableObject
{
   [ObservableProperty]
   private string label;

   [ObservableProperty]
   private string? value;
}