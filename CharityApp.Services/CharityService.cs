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
        private IUnitOfWork _unitOfWork;

        public CharityService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IEnumerable<Charity>> GetAll()
        {
            return _unitOfWork.CharityRepository.GetAll();
        }

        public Charity GetById(int id)
        {
            return _unitOfWork.CharityRepository.Get(id);
        }

        public void SoftDelete(int id)
        {
            var charityToDel = _unitOfWork.CharityRepository.Get(id);

            if (charityToDel == null)
                throw new Exception("SoftDelete Error: Charity not found");

            charityToDel.Active = false;

            _unitOfWork.CharityRepository.Update(charityToDel);

            _unitOfWork.SaveChanges();
        }
    }
}
