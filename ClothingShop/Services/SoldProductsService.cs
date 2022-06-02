using ClothingShop.Data;
using ClothingShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Services
{
    class SoldProductStatisticService : ISoldProductService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IRepository _repository;

        public SoldProductStatisticService()
        {
            _repository = _unitOfWork.Repository;
        }

        public IEnumerable<SoldProductsStatistic> GetAllStatisticList()
        { 
            return _repository.GetAllStatisticList();
        }
        

        public void AddSoldProductStatistic(SoldProductsStatistic soldProducts)
        {
            _repository.AddSoldProduct(soldProducts);
            _unitOfWork.SaveSoldChanges();
        }
    }
}

