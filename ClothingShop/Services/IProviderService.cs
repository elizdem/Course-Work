using ClothingShop.Entities;
using System.Collections.Generic;

namespace ClothingShop.Services
{
    interface IProviderService
    {
        void AddProviders(Provider provider);
        IEnumerable<Provider> GetProviders();
        void RemoveProvider(int id);
    }
}