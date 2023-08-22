using AutoMapper;
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
    public class BaseService<T, TDb,TSearch> : IService<T,TSearch> where TDb : class where T : class where TSearch:BaseSearchObject
    {
        protected EDentistDbContext _context;
        protected IMapper _mapper { get; set; }

        public BaseService(EDentistDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<List<T>> Get(TSearch search=null)
        {
            var query=_context.Set<TDb>().AsQueryable();
            query = AddFilter(query, search);
            if (search?.Page.HasValue == true && search.PageSize.HasValue == true)
            {
                query=query.Take(search.PageSize.Value).Skip(search.Page.Value * search.PageSize.Value);
            }

            var list= await query.ToListAsync();
            return _mapper.Map<List<T>>(list);
            
        }
        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query,TSearch? search = null)
        {
            return query;
        }
    }
}
