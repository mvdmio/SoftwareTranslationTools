using System.Windows.Controls;

namespace STT.WPF.Controls;

public partial class TextInput : UserControl
{
    public string Label { get; set; }
    public string? Value { get; set; }

    public TextInput()
    {
        Label = string.Empty;

        InitializeComponent();
    }
}