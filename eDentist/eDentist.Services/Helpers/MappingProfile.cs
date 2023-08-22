using AutoMapper;
using eDentist.Model;
using eDentist.Model.Models;
using eDentist.Model.Requests;
using eDentist.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<User, Models.UserModel>();
            CreateMap<User, UserModel>();
            CreateMap<City, CityModel>();
            CreateMap<CityInsertRequest, City>();
            CreateMap<Country, CountryModel>();
            CreateMap<CountryInsertRequest, Country>();
        }
    }
}
