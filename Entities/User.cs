namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class User
{
    public int userid { get; set; }
    public string namalengkap { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string status { get; set; }


}