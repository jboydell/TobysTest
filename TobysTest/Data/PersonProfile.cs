using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TobysTest.Models;
using TobysTest.ViewModels;

namespace TobysTest.Data
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonModel, PersonDataEntryViewModel>().ReverseMap();
            CreateMap<PersonModel, PersonInfoViewModel>().ReverseMap();
            //.ForMember(p => p.Fullname, opt => opt.Ignore())
            //.ForMember(p => p.DateOfBirth, opt => opt.Ignore());
        }
    }
}
