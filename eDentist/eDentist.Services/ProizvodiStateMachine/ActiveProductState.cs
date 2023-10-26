using AutoMapper;
using eDentist.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDentist.Services.ProizvodiStateMachine
{
    public class ActiveProductState : BaseState
    {
        public ActiveProductState(IServiceProvider serviceProvider, EDentistDbContext context, IMapper mapper) : base(serviceProvider, context, mapper)
        {
        }
    }
}
