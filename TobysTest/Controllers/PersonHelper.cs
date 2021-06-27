using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace TobysTest.Controllers
{
    public static class PersonHelper
    {
        public static string GetFirstNameOnly(string personFullname)
        {
            var firstName = "";

            var trimmedName = personFullname.Trim();
            var firstSpace = trimmedName.IndexOf(" ");
            if (firstSpace > 0)
            {
                firstName = trimmedName.Substring(0, firstSpace);
            }
            return firstName;
        }

        public static int GetVowelsInName(string personFirstNameOnly)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            return personFirstNameOnly.ToLower().Count(x => vowels.Contains(x));
        }

        public static DateTime[] GetDaysLeadingToBirthday(DateTime personDateOfBirth, int numberOfDays)
        {
            var dates = new DateTime[numberOfDays];
            var age = personDateOfBirth.GetAge();
            var nextBirthday = personDateOfBirth.AddYears(age+1);

            var startDate = nextBirthday.AddDays((numberOfDays-1) * -1);
            var dateIndex = 0;
            foreach (var day in EachDay(startDate, nextBirthday))
            {
                dates[dateIndex] = day;
                dateIndex++;
            }

            return dates;
        }

        private static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
    }
}