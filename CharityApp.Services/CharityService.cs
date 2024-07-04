using CharityApp.Core;
using CharityApp.Data.UnitOfWork;
using CharityApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CharityApp.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CharityApp.Services
{
    public class CharityService(IUnitOfWork unitOfWork) : ICharityService
    {
        public IEnumerable<Category> GetCategories()
        {
            return unitOfWork.CategoryRepository.GetAll()
                .Include(cat => cat.Subcategories);
        }

        public IEnumerable<Subcategory> GetSubcategories(int categoryId)
        {
            return unitOfWork.SubcategoryRepository.Find(q => q.CategoryId == categoryId).Take(100);
        }


        public IEnumerable<Organization> GetAllAsync()
        {
            return unitOfWork.OrganizationRepository.GetAll();
        }

        public Organization GetById(Guid id)
        {
            return unitOfWork.OrganizationRepository.Get(id);
        }

        public void SoftDelete(int id)
        {
            var charityToDel = unitOfWork.OrganizationRepository.Get(id);

            if (charityToDel == null)
                throw new Exception("SoftDelete Error: Organization not found");

            charityToDel.Active = false;

            unitOfWork.OrganizationRepository.Update(charityToDel);

            unitOfWork.SaveChanges();
        }

        public IEnumerable<Organization> Search(string input)
        {
            // How will user find (11th) result if scrolling? might see huge list and refine search. might have valid 50+ results. 
            // might need to incorporate location / ordering & searching
            var organizations = unitOfWork.OrganizationRepository
                //.Find(q =>  q.NpoName == input || q.Description == input || q.Objective == input || q.Theme == input )
                //.Where(q => q.Active == true);
                .Find(q => q.Active == true)
                .Where(o => o.NpoName.Contains(input) || o.Description.Contains(input) ||
                            o.Description.Contains(input) || o.Objective == input || o.Theme == input)
                .Take(10);

            return organizations;
        }
    }
}
