using Microsoft.AspNetCore.Components;
using Project.Models;

namespace Project.Shared
{
  public partial class Pipeline : ComponentBase
  {
    [Parameter]
    public List<Lead> Leads { get; set; } = new List<Lead>();
  }
}