using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CharityApp.Core;

namespace CharityApp.Services.Interfaces
{
    public interface ICharityService
    {
        Task<IEnumerable<Organization>> GetAll();
        
        Organization GetById(Guid id);
        void SoftDelete(int id);

    }
}
