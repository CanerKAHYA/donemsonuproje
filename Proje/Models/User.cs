using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using spering_html.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.CodeAnalysis;
namespace spering_html.Models
{
    public class User
{   [Key]
    [AllowNull]
    public int? Id { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    public string? PhotoPath { get; set; }


    public string? Occupation { get; set; }
    public string? Location { get; set; }
    public string? Hobby { get; set; }
    [AllowNull]
    public ICollection<UserPhoto> Photos { get; set; }
    public UserRole Role { get; set; }
}
public enum UserRole
{
    Admin,
    User
}

}



