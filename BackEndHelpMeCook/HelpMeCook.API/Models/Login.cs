using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HelpMeCook.DTO;

public class Login 
{
    public int LoginID{ get; set;}
    public string Username { get; set; }
    public string Password { get; set; }

}