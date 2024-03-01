using CharityApp.Core;
using CharityApp.Data.UnitOfWork;
using CharityApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharityApp.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CharityApp.Services
{
    public class CharityService : ICharityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CharityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Category> GetCategories()
        {
            return _unitOfWork.CategoryRepository.GetAll().Include(cat => cat.Subcategories);
        }

        public IEnumerable<Subcategory> GetSubcategories(int categoryId)
        {
            return _unitOfWork.SubcategoryRepository.Find(q => q.CategoryId == categoryId).Take(100);
        }


        public IEnumerable<Organization> GetAllAsync()
        {
            return _unitOfWork.OrganizationRepository.GetAll();
        }

        public Organization GetById(Guid id)
        {
            return _unitOfWork.OrganizationRepository.Get(id);
        }

        public void SoftDelete(int id)
        {
            var charityToDel = _unitOfWork.OrganizationRepository.Get(id);

            if (charityToDel == null)
                throw new Exception("SoftDelete Error: Organization not found");

            charityToDel.Active = false;

            _unitOfWork.OrganizationRepository.Update(charityToDel);

            _unitOfWork.SaveChanges();
        }
    }
}
