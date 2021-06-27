using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TobysTest.Models;
using TobysTest.ViewModels;

namespace TobysTest.Controllers
{
    public class PersonController : Controller
    {
        private readonly IMapper _mapper;

        public PersonController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult PersonDataEntry()
        {
            var person = new PersonModel();
            PersonDataEntryViewModel model = _mapper.Map<PersonDataEntryViewModel>(person);

            ViewData["Title"] = "Person Data Entry";

            return View(model);
        }

        [HttpPost]
        public IActionResult PersonDataEntry(PersonDataEntryViewModel model)
        {
            if (model.DateOfBirth > DateTime.Now)
            {
                ModelState.AddModelError("DateOfBirth", "Your date of birth cannot be in the future.");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var person = _mapper.Map<PersonModel>(model);

            return new RedirectToActionResult("PersonInfo", "Person", person);
        }

        public IActionResult PersonInfo(PersonModel person)
        {
            if (person.DateOfBirth == null)
            {
                var personDataEntry = _mapper.Map<PersonDataEntryViewModel>(person);
                return RedirectToAction("PersonDataEntry", "Person", personDataEntry);
            }

            var personsDateOfBirth = (DateTime) person.DateOfBirth;
            person.FirstNameOnly = PersonHelper.GetFirstNameOnly(person.Fullname);
            person.Age = personsDateOfBirth.GetAge();
            person.VowelsInName = PersonHelper.GetVowelsInName(person.Fullname);
            person.DaysUntilBirthday = personsDateOfBirth.GetDaysUntilBirthday();
            person.DaysLeadingToBirthday = PersonHelper.GetDaysLeadingToBirthday(personsDateOfBirth, 14);

            var model = _mapper.Map<PersonInfoViewModel>(person);

            ViewData["Title"] = "Person Information";

            return View(model);
        }
    }
}
