using Domain.Models.Abstractions;
using Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Repositories
{
    public interface ICuentaRepository : IGenericRepository<Cuenta>
    {
    }
}
