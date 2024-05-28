using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using spering_html.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace spering_html.Models
{public class UserPhoto
    {
        [Key]
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
    }