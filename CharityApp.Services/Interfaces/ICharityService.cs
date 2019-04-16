using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CharityApp.Core;

namespace CharityApp.Services.Interfaces
{
    public interface ICharityService
    {
        Task<IEnumerable<Charity>> GetAll();
        
        Charity GetById(int id);
        void SoftDelete(int id);

    }
}
