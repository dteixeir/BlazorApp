using Microsoft.AspNetCore.Components;
using MudBlazor;
using Project.Models;

namespace Project.Shared
{
  

  public partial class Dialer : ComponentBase
  {
    [Parameter]
    public required BorrowerResponse Borrower { get; set; }

    [Parameter]
    public required string NumberToDial { get; set; }
  }
}
