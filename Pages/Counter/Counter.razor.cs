using Microsoft.AspNetCore.Components;
using Project.Models;
using Project.Shared;
using Project.Shared.Buttons;

namespace Project.Pages
{
  public partial class Counter : ComponentBase
  {
    private List<Lead> Leads = ComponentData.LeadData.Leads;

    private List<ButtonGroupButton> ButtonGroupButtons = new List<ButtonGroupButton> {
      new ButtonGroupButton() {Label = "Unallocated"},
      new ButtonGroupButton() {Label = "Pipeline"}
    };

    private int currentCount = 0;

    private BorrowerResponse borrower = new BorrowerResponse
    {
      GCID = "GCID",
      IsPrimary = true,
      PEID = "PEID",
      FirstName = "Patti",
      LastName = "Wollcott",
      EmailAddress = "EmailAddress",
      MobileNumber = "(555) 555-5555",
      HomeNumber = "HomeNumber",
      WorkNumber = "WorkNumber",
    };

    private void IncrementCount()
    {
      currentCount++;
    }


  }
}