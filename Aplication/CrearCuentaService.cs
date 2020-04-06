using Domain.Models.Abstractions;
using Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    public class CrearCuentaService
    {
        readonly IUnitOfWork _unitOfWork;

        public CrearCuentaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public CrearCuentaResponse Ejecutar(CrearCuentaBancariaRequest request)
        {
            Cuenta cuenta = _unitOfWork.CuentaRepository.FindFirstOrDefault(t => t.Numero == request.Numero);
            if (cuenta == null)
            {
                Cuenta cuentaNueva = new CuentaAhorro();//Debe ir un factory que determine que tipo de cuenta se va a crear
                cuentaNueva.Nombre = request.Nombre;
                cuentaNueva.Numero = request.Numero;
                _unitOfWork.CuentaRepository.Add(cuentaNueva);
                _unitOfWork.Commit();
                return new CrearCuentaResponse() { Mensaje = $"Se creó con exito la cuenta {cuentaNueva.Numero}." };
            }
            else
            {
                return new CrearCuentaResponse() { Mensaje = $"El número de cuenta ya exite" };
            }
        }



    }
    public class CrearCuentaBancariaRequest
    {
        public string Nombre { get; set; }
        public string TipoCuenta { get; set; }
        public string Numero { get; set; }
    }
    public class CrearCuentaResponse
    {
        public string Mensaje { get; set; }
    }
}
