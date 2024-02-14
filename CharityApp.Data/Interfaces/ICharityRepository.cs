using CharityApp.Core;
using CharityApp.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharityApp.Data.Interfaces
{
    public interface ICharityRepository : IRepository<Organization>
    {
        IEnumerable<Organization> GetAllByCharityTypeId(int charityTypeId);//This is an example. Not expected to be implemented in this way. 
    }
}
