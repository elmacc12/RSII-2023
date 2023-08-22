using AutoMapper;
using eDentist.Model.Models;
using eDentist.Model.Requests;
using eDentist.Services.Database;
using eDentist.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services.Services
{
    public class CountryService : ICountryService
    {
        EDentistDbContext _context;
        public IMapper _mapper { get; set; }

        public CountryService(EDentistDbContext c, IMapper mapper)
        {
            _context = c;
            _mapper = mapper;
        }
        public CountryModel Insert(CountryInsertRequest r)
        {
            var country = new Country();
            _mapper.Map(r,country);
            _context.Countries.Add(country);
            _context.SaveChanges();
            return _mapper.Map<CountryModel>(country);

        }
    }
}
