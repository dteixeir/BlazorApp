using System.Linq;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using MudBlazor.Utilities;
using Project.Models;
using System.Linq;

namespace Project.Shared
{
  public partial class PipelineDetails : ComponentBase
  {
    [Parameter]
    public required Lead LeadDetails { get; set; }

    private BorrowerResponse GetPrimaryBorrower(Lead lead)
    {
      return lead.Borrowers
        .Where(x => x.IsPrimary)
        .Single();
    }

    private List<BorrowerResponse> GetBorrowers => 
      LeadDetails.Borrowers
        .OrderBy(x => x.IsPrimary == true)
        .ToList();
  }
}