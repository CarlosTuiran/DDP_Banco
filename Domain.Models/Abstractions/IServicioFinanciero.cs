using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Abstractions
{
    public interface IServicioFinanciero
    {
        //Comportamineto que tendran las clases
        string Nombre { get; set; }
        string Numero { get; set; }
        double Saldo { get; }

        void Retirar(double valor);
        void Consignar(double valor);
        void Trasladar(IServicioFinanciero servicioFinanciero, double valor);

    }
}
