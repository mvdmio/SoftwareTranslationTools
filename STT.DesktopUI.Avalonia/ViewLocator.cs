using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using STT.DesktopUI.Avalonia.ViewModels.Base;

namespace STT.DesktopUI.Avalonia;

public class ViewLocator : IDataTemplate
{
   public Control Build(object? data)
   {
      if (data is null)
         return NotFound("Data is null");

      if (data is not ViewModelBase viewModel)
         return NotFound($"{data.GetType().Name} is not a ViewModelBase");

      var name = data.GetType().FullName!.Replace("ViewModel", "View");
      var type = Type.GetType(name);

      if (type is null)
         return NotFound($"View not found: {name}");

      var control = (Control)Activator.CreateInstance(type)!;
      control.DataContext = viewModel;
      return control;
   }

   public bool Match(object? data)
   {
      return data is ViewModelBase;
   }

   private static Control NotFound(string text)
   {
      return new TextBlock {
         Text = text
      };
   }
}
