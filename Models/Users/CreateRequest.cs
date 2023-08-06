namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class CreateRequest
{
    // public string userid { get; set; }

    public string namalengkap { get; set; }

    public string username { get; set; }


    public string Password { get; set; }

    public string status { get; set; }

   
}