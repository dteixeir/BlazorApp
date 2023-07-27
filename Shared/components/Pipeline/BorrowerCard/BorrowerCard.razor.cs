using Microsoft.AspNetCore.Components;
using Project.Models;

namespace Project.Shared
{
  public partial class BorrowerCard : ComponentBase
  {
    [Parameter]
    public required BorrowerResponse Borrower { get; set; }
  }
}
