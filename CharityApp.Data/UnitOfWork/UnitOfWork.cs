using CharityApp.Core;
using CharityApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharityApp.Core.Domain;
using CharityApp.Data.Repos;

namespace CharityApp.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly DatabaseContext _dbContext;
        private readonly ISubcategoryRepository _subcategoryRepository;

        public UnitOfWork(DatabaseContext databaseBaseContext, 
            IOrganizationRepository organizationRepository, 
            ICategoryRepository categoryRepository, 
            ISubcategoryRepository subcategoryRepository)
        {
            _organizationRepository = organizationRepository;
            _dbContext = databaseBaseContext;
            CategoryRepository = categoryRepository;
            _subcategoryRepository = subcategoryRepository;
        }

        public IRepository<Organization> OrganizationRepository => _organizationRepository;
        public IRepository<Category> CategoryRepository { get; }

        public IRepository<Subcategory> SubcategoryRepository => _subcategoryRepository;

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        /// <summary>
        /// Saves all pending changes to database and returns number of rows affected.
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
