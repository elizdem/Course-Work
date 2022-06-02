using ClothingShop.Entities;
using System.Collections.Generic;

namespace ClothingShop.Services
{
    interface ISoldProductService
    {
        IEnumerable<SoldProductsStatistic> GetAllStatisticList();
        void AddSoldProductStatistic(SoldProductsStatistic soldProducts);

    }
}
