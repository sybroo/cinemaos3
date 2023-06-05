using System.ComponentModel.DataAnnotations;

namespace cinemaos3.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Voornaam is een verplicht veld")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Achternaam is een verplicht veld")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Geldig e-mailadress invullen")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Bericht is een verplicht veld")]
        public string Message { get; set; }

    }
}
