using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobysTest.ViewModels
{
    public class PersonDataEntryViewModel
    {

        [Required(ErrorMessage = "Please enter your full name."), RegularExpression("^([a-zA-Z]{2,}\\s[a-zA-Z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)", ErrorMessage = "Please enter your first and last name.")]
        [Display(Name = "Your Full Name")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Please enter your Date of Birth.")]
        [Display(Name = "Your Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
    }
}
