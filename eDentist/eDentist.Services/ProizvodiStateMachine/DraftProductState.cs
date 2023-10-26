using AutoMapper;
using Azure.Core;
using eDentist.Model.Models;
using eDentist.Model.Requests;
using eDentist.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services.ProizvodiStateMachine
{
    public class DraftProductState : BaseState
    {
        public DraftProductState(IServiceProvider serviceProvider, EDentistDbContext context, IMapper mapper) : base(serviceProvider, context, mapper)
        {
        }

        public override async Task<ProductModel> Update(int id, ProductUpdateRequest request)
        {
            var table = _context.Set<Product>();
            Product entity = await table.FindAsync(id);
            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductModel>(entity);
        }

        public override async Task<ProductModel> Activate(int id)
        {
            var table = _context.Set<Product>();
            Product entity = await table.FindAsync(id);
            entity.StateMachine = "active";
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductModel>(entity);
        }

    }
}
