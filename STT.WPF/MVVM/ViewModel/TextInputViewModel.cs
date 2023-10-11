using CommunityToolkit.Mvvm.ComponentModel;
using STT.WPF.MVVM.Core;

namespace STT.WPF.MVVM.ViewModel;

public partial class TextInputViewModel : ViewModelBase
{
   [ObservableProperty]
   private string? _label;

   [ObservableProperty]
   private string? _value;
}