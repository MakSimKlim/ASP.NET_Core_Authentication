﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Authentication.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public int? UsernameChangeLimit { get; set; } = 10;
        [Required]
        public byte[]? ProfilePicture { get; set; }
    }
}
