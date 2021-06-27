using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobysTest
{
    public static class ExtensionMethods
    {
        public static int GetAge(this DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }

        public static int GetDaysUntilBirthday(this DateTime dateOfBirth)
        {
            var nextBirthday = dateOfBirth.AddYears(DateTime.Today.Year - dateOfBirth.Year);
            if (nextBirthday < DateTime.Today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            return (nextBirthday - DateTime.Today).Days;
        }
    }
}
