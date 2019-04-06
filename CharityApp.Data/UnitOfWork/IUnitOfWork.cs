using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CharityApp.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
       int Task<int> SaveChanges();
    }
}
