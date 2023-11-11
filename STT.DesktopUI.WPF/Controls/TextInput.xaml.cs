using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using STT.WPF.Core;

namespace STT.WPF.Controls;

public partial class TextInput : UserControl
{
   public TextInput()
   {
      DataContext = new TextInputViewModel();
      InitializeComponent();
   }
}

public partial class TextInputViewModel : ViewModelBase
{
   [ObservableProperty]
   private string? _label;

   [ObservableProperty]
   private string? _value;
}