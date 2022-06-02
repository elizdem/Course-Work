using ClothingShop.Data;
using ClothingShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Services
{
    class ProviderService : IProviderService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IRepository _repository;

        public ProviderService()
        {
            _repository = _unitOfWork.Repository;
        }

        public IEnumerable<Provider> GetProviders()
        {
            return _repository.GetProviders();
        }

        public IEnumerable<Provider> GetAllProviders()
        {
            return _repository.GetAllProviders();
        }

        public void AddProviders(Provider provider)
        {
            _repository.AddProvider(provider);
            _unitOfWork.SaveProviderChanges();
        }

        public void RemoveProvider(int id)
        {
            _repository.RemoveProvider(id);
            _unitOfWork.SaveProviderChanges();
        }

    }
}
