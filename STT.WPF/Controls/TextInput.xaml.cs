using System.Windows.Controls;
using STT.WPF.ViewModel;

namespace STT.WPF.Controls;

public partial class TextInput : UserControl
{
   private TextInputViewModel _viewModel;

   public TextInput()
   {
      DataContext = _viewModel = new TextInputViewModel();

      InitializeComponent();
   }
}