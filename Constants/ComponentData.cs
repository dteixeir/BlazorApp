using Project.Models;

public class ComponentData
{
  public class LeadData {
    public static List<Lead> Leads  = new List<Lead> {
      new Lead {
        LeadId = "3576982351",
        Borrowers = new List<BorrowerResponse> {
          new BorrowerResponse {
            GCID = "GCID 1234",
            IsPrimary = true,
            PEID = "PEID 1234",
            FirstName = "Patti",
            LastName = "Wollcott",
            EmailAddress = "EmailAddress",
            MobileNumber = "(555) 555-5555",
            HomeNumber = "(333) 333-3333",
            WorkNumber = "(444) 444-4444"
          },
          new BorrowerResponse {
            GCID = "GCID",
            IsPrimary = false,
            PEID = "PEID",
            FirstName = "Walter",
            LastName = "Wollcott",
            EmailAddress = "EmailAddress",
            MobileNumber = "(555) 555-5555",
            HomeNumber = "(111) 111-1111",
            WorkNumber = "(222) 222-2222"
          }
          ,
          new BorrowerResponse {
            GCID = "GCID",
            IsPrimary = false,
            PEID = "PEID",
            FirstName = "Penny",
            LastName = "Wollcott",
            EmailAddress = "EmailAddress",
            MobileNumber = "(555) 555-5555",
            HomeNumber = "(111) 111-1111",
            WorkNumber = "(222) 222-2222"
          }
        }
      },
      new Lead {
        LeadId = "6753982351",
        Borrowers = new List<BorrowerResponse> {
          new BorrowerResponse {
            GCID = "GCID 1234",
            IsPrimary = true,
            PEID = "PEID 1234",
            FirstName = "Tiffany",
            LastName = "Mulhaney",
            EmailAddress = "EmailAddress",
            MobileNumber = "(555) 555-5555",
            HomeNumber = "(333) 333-3333",
            WorkNumber = "(444) 444-4444"
          }
        }
      }
    };
  }
}