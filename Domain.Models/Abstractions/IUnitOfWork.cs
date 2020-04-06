using Domain.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        ICuentaRepository CuentaRepository { get; }
        int Commit();
    }
}
