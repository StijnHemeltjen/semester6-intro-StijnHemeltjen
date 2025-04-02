using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Voornaam { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Wachtwoord { get; set; }

        [Required]
        [Compare("Wachtwoord")]
        [DataType(DataType.Password)]
        public string BevestigWachtwoord { get; set; }
    }
}
