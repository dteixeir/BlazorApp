using Microsoft.AspNetCore.Components;

namespace Project.Shared.Buttons
{
  public partial class OutlineButton : ComponentBase
  {
    [Parameter]
    public string Label { get; set; } = "Test";

    private async void HandleClick()
    {
      Console.WriteLine("Before");
      await Task.Delay(2000);
      Console.WriteLine("After");
    }
  }
}