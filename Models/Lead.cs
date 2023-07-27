namespace Project.Models
{
  public class Lead
  {
    public required string LeadId { get; set; }
    public required List<BorrowerResponse> Borrowers { get; set; }
  }
}