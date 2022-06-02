using ClothingShop.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Data
{
    class UnitOfWork : IUnitOfWork
    {
        public IRepository Repository { get; } = new Repository();
        public void SaveChanges()
        {
            //serilization logic 
            var products = Repository.GetAllProducts();

            var json = JsonConvert.SerializeObject(products, Formatting.Indented,
                        new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            using (var f = File.CreateText("Данные магазина.json"))
            {
                f.Write(json);
            }
        }
        
        public void SaveSoldChanges()
        {
            var soldProductsStatistic = Repository.GetStatistics();
            var json = JsonConvert.SerializeObject(soldProductsStatistic, Formatting.Indented,
                        new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            using (var f = File.CreateText("Статистика.json"))
            {
                f.Write(json);
            }
        }

        public void SaveProviderChanges()
        {
            //serilization logic 
            var providers = Repository.GetAllProviders();

            var json = JsonConvert.SerializeObject(providers, Formatting.Indented,
                        new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });

            using (var f = File.CreateText("Поставщики.json"))
            {
                f.Write(json);
            }
        }
    }
}
