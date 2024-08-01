using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HelpMeCook.DTO;

public class User 
{
    public int UserID { get; set;}
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime CratedDate { get; set; }

    public ICollection<Recipe> Recipes  { get; set; }
    public Login Login { get; set; }
}