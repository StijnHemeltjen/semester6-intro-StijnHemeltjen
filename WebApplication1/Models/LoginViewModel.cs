﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Wachtwoord { get; set; }

        public bool OnthoudMij { get; set; }
    }
}
