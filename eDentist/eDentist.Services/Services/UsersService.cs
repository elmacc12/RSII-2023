using AutoMapper;
using eDentist.Model;
using eDentist.Model.Requests;
using eDentist.Services.Database;
using eDentist.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services.Services
{
    public class UsersService : IUsersService
    {
        EDentistDbContext _context;
        public IMapper _mapper { get; set; }

        public UsersService(EDentistDbContext c, IMapper mapper)
        {
            _context = c;
            _mapper = mapper;
        }

        public List<UserModel> Get()
        {
            var data = _context.Users.ToList();

            return _mapper.Map<List<UserModel>>(data);
        }

        public UsersInsertRequest Insert(UsersInsertRequest r)
        {
            throw new NotImplementedException();
        }
    }
}
