using System;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Infra.DataAccess;

namespace Aplication.Test
{
    [TestClass]
    public class UnitTest1
    {
        BancoContext _context;

        [SetUp]
        public void Setup()
        {
            /*var optionsSqlServer = new DbContextOptionsBuilder<BancoContext>()
             .UseSqlServer("Server=.\\;Database=Banco;Trusted_Connection=True;MultipleActiveResultSets=true")
             .Options;*/

            var optionsInMemory = new DbContextOptionsBuilder<BancoContext>().UseInMemoryDatabase("Banco").Options;

            _context = new BancoContext(optionsInMemory);
        }

        [Test]
        public void CrearCuentaBancariaTest()
        {
            var request = new CrearCuentaBancariaRequest { Numero = "1111", Nombre = "aaaaa", TipoCuenta = "Ahorro" };
            CrearCuentaBancariaService _service = new CrearCuentaBancariaService(new UnitOfWork(_context));
            var response = _service.Ejecutar(request);
            Assert.AreEqual("Se cre� con exito la cuenta {request.Numero}.", response.Mensaje);
        }
    }
}
