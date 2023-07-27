using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Project.Shared.Buttons
{
  public partial class OutlineIconButton : ComponentBase
  {
    [Parameter]
    public string Icon { get; set; } = Icons.Material.Filled.Delete;

    [Parameter]
    public Color Color { get; set; } = Color.Primary;

    private async void HandleClick()
    {
      Console.WriteLine("Before");
      await Task.Delay(2000);
      Console.WriteLine("After");
    }
  }
}