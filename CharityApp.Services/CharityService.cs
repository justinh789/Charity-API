using CharityApp.Core;
using CharityApp.Data.UnitOfWork;
using CharityApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CharityApp.Services
{
    public class CharityService : ICharityService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CharityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Organization>> GetAll()
        {
            return _unitOfWork.CharityRepository.GetAll();
        }

        public Organization GetById(Guid id)
        {
            return _unitOfWork.CharityRepository.Get(id);
        }

        public void SoftDelete(int id)
        {
            var charityToDel = _unitOfWork.CharityRepository.Get(id);

            if (charityToDel == null)
                throw new Exception("SoftDelete Error: Organization not found");

            charityToDel.Active = false;

            _unitOfWork.CharityRepository.Update(charityToDel);

            _unitOfWork.SaveChanges();
        }
    }
}
