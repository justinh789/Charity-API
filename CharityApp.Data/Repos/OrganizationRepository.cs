using CharityApp.Core;
using CharityApp.Data.Interfaces;
using CharityApp.Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CharityApp.Data.Repos
{
    public class OrganizationRepository(DbContext db) : Repository<Organization>(db), IOrganizationRepository
    {
        public IEnumerable<Organization> GetAllByCharityTypeId(int charityTypeId)//This is an example. Not expected to be implemented in this way. 
        {
            throw new NotImplementedException("This is an example. Not expected to be implemented in this way. ");
        }
    }
}
