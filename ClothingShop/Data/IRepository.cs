using System.Collections.Generic;
using ClothingShop.Entities;

namespace ClothingShop.Data
{
    interface IRepository
    {
        IEnumerable<Product> GetProductsFromJSON();
        IEnumerable<Product> GetAllProducts();
        
        void AddProduct(Product product);
        //void EditProduct(int id);
        void RemoveProduct(int id);

        IEnumerable<Provider> GetProviders();
        IEnumerable<Provider> GetAllProviders();
        void AddProvider(Provider provider);
        void RemoveProvider(int id);


        IEnumerable<SoldProductsStatistic> GetAllStatisticList();
        IEnumerable<SoldProductsStatistic> GetStatistics();
        void AddSoldProduct(SoldProductsStatistic soldProducts);

    }
}