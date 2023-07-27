using System.Linq;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudBlazor.Utilities;
using Project.Models;

namespace Project.Shared
{
  public partial class PipelineLeads : ComponentBase
  {
    [Parameter]
    public List<Lead> Leads { get; set; } = new List<Lead>();

    private async void HandleClick(int index)
    {
      Console.WriteLine($"Before: {index}");
      await Task.Delay(2000);
      Console.WriteLine("After");
    }

    private BorrowerResponse GetPrimaryBorrower(Lead lead)
    {
      return lead.Borrowers
        .Where(x => x.IsPrimary)
        .Single();
    }

    // private string GetLeadSummaryClasses(int index)
    // {
    //   var styles = new CssBuilder("lead-summary d-flex flex-column py-2 px-4");

    //   if(index == 0) {
    //     styles.AddClass("active-lead");
    //   }

    //   return styles;
    // }
  }
}