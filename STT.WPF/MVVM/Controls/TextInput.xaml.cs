using System.Windows.Controls;
using STT.WPF.MVVM.ViewModel;

namespace STT.WPF.MVVM.Controls;

public partial class TextInput : UserControl
{
   private TextInputViewModel _viewModel;

   public TextInput()
   {
      DataContext = _viewModel = new TextInputViewModel();

      InitializeComponent();
   }
}