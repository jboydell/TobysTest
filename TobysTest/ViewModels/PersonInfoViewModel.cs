using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobysTest.ViewModels
{
    public class PersonInfoViewModel
    {
        [Display(Name = "Number of Vowels in your name")]
        public int VowelsInName { get; set; }
        [Display(Name = "Your first name")]
        public string FirstNameOnly { get; set; }
        [Display(Name = "Your Age")]
        public int Age { get; set; }
        [Display(Name = "Number of days until your birthday")]
        public int DaysUntilBirthday { get; set; }
        public DateTime[] DaysLeadingToBirthday { get; set; }

    }
}
