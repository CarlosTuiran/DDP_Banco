using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infra.DataAccess
{
    public class BancoContext : DbContextBase
    {
        public BancoContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<CuentaAhorro> CuentasAhorro { get; set; }
        public DbSet<CuentaCorriente> CuentasCorriente { get; set; }

    }
}
