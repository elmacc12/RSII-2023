﻿using AutoMapper;
using eDentist.Model.Models;
using eDentist.Model.Requests;
using eDentist.Model.SearchObjects;
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
    public class CountryService : BaseCrudService<CountryModel,Country,BaseSearchObject,CountryInsertRequest,CountryUpdateRequest>,ICountryService
    {

        public CountryService(EDentistDbContext c, IMapper mapper) : base(c, mapper) { }


    }
}
