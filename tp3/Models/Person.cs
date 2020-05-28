using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tp3.Models
{
    public class Person
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The person must have a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The person must have a surname.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "The person must have a birthdate.")]
        public string Birthday { get; set; }
    }
}
