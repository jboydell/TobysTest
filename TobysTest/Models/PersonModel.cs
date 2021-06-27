using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TobysTest.Models
{
    public class PersonModel
    {
        public string Fullname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int VowelsInName { get; set; }
        public string FirstNameOnly { get; set; }
        public int Age { get; set; }
        public int DaysUntilBirthday { get; set; }
        public DateTime[] DaysLeadingToBirthday { get; set; }

        public PersonModel()
        {
            DateOfBirth = null;
        }
    }
}
