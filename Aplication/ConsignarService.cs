using Domain.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    public class ConsignarService
    {
        readonly IUnitOfWork _unitOfWork;

        public ConsignarService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ConsignarResponse Ejecutar(ConsignarRequest request)
        {
            var cuenta = _unitOfWork.CuentaRepository.FindFirstOrDefault(t => t.Numero == request.NumeroCuenta);
            if (cuenta != null)
            {
                cuenta.Consignar(request.Valor);
                _unitOfWork.Commit();
                return new ConsignarResponse() { Mensaje = $"Su Nuevo saldo es {cuenta.Saldo}." };
            }
            else
            {
                return new ConsignarResponse() { Mensaje = $"Número de Cuenta No Válido." };
            }
        }
    }
    public class ConsignarRequest
    {
        public string NumeroCuenta { get; set; }
        public double Valor { get; set; }
    }
    public class ConsignarResponse
    {
        public string Mensaje { get; set; }
    }
}

