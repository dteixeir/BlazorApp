using Microsoft.AspNetCore.Components;
using MudBlazor;
using Project.Models;

namespace Project.Shared.Buttons
{
  public partial class ButtonGroupToggle : ComponentBase
  {
    [Parameter]
    public required List<ButtonGroupButton> Buttons { get; set; } = new List<ButtonGroupButton>();

    [Parameter]
    public int ActiveButton { get; set; } = 0;

    private async void HandleClick(int index)
    {
      ActiveButton = index;

      Console.WriteLine($"Before: {index}");
      await Task.Delay(2000);
      Console.WriteLine("After");
    }

    private string GetCssClass(int index)
    {
      if (index == 0) return "rounded-l-xl";
      if (index == (Buttons.Count - 1)) return "rounded-r-xl";
      return "";
    }

    private Variant GetVariant(int index)
    {
      return index == ActiveButton ? Variant.Filled : Variant.Outlined;
    }
  }
}