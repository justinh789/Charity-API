using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CharityApp.Core;
using CharityApp.Core.Domain;

namespace CharityApp.Services.Interfaces
{
    public interface ICharityService
    {
        IEnumerable<Organization> GetAllAsync();
        
        Organization GetById(Guid id);
        IEnumerable<Category> GetCategories();
        IEnumerable<Subcategory> GetSubcategories(int categoryId);
        void SoftDelete(int id);

    }
}
