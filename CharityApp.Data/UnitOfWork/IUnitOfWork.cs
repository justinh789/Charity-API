using CharityApp.Core;
using CharityApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CharityApp.Core.Domain;

namespace CharityApp.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Organization> OrganizationRepository { get;  }

        /*IRepository<Category> CategoryRepository { get; }*/
        IRepository<Category> CategoryRepository { get; }
        IRepository<Subcategory> SubcategoryRepository { get; }

        Task<int> SaveChanges();

    }
}
