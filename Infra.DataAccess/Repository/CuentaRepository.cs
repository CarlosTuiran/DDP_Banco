using Domain.Models.Abstractions;
using Domain.Models.Repositories;
using Infra.DataAccess.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class CuentaRepository : IGenericRepository<CuentaBancaria>, ICuentaRepository
    {
        public CuentaBancariaRepository(IDbContext context)
              : base(context)
        {

        }
    }
}
