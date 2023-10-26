using AutoMapper;
using eDentist.Model.Models;
using eDentist.Model.Requests;
using eDentist.Model.SearchObjects;
using eDentist.Services.Database;
using eDentist.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services.Services
{
    public class ColorService : BaseCrudService<ColorModel, Color, BaseSearchObject, ColorInsertRequest, ColorUpdateRequest>,IColorService
    {
        public ColorService(EDentistDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
