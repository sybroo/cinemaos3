﻿using System.ComponentModel.DataAnnotations;

namespace cinemaos3.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Gelieve uw voornaam in te vullen")]
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Achternaam is een verplicht veld")]
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is verplicht")]
        [EmailAddress(ErrorMessage = "Geen geldig email adres")]
        public string Email { get; set; }

        [Display(Name = "Telefoonnummer")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Bericht is verplicht")]
        [Display(Name = "Bericht")]
        public string Message { get; set; }

    }
}
