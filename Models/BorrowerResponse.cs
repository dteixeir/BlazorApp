namespace Project.Models
{
  public class BorrowerResponse
  {
    public string GCID { get; set; } = string.Empty;
    public bool IsPrimary { get; set; } = true;
    public string PEID { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public string MobileNumber { get; set; } = string.Empty;
    public string HomeNumber { get; set; } = string.Empty;
    public string WorkNumber { get; set; } = string.Empty;
  }
}