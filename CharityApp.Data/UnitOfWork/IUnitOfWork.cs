using CharityApp.Core;
using CharityApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CharityApp.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Charity> CharityRepository { get;  }

        Task<int> SaveChanges();

    }
}
