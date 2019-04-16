using CharityApp.Core;
using CharityApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CharityApp.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ICharityRepository _charityRepository;
        private DatabaseContext _dbContext;

        public UnitOfWork(DatabaseContext databaseBaseContext, ICharityRepository charityRepository)
        {
            _charityRepository = charityRepository;
            _dbContext = databaseBaseContext;
        }

        public IRepository<Charity> CharityRepository
        {
            get{  return _charityRepository; }
        }

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
