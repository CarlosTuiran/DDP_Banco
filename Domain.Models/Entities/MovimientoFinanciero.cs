using Domain.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class MovimientoFinanciero : Entity<int>
    {
        public Cuenta Cuenta { get; set; }
        public double ValorRetiro { get; set; }
        public double ValorConsignacion { get; set; }
        public DateTime FechaMovimiento { get; set; }
    }
}
