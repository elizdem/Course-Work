using ClothingShop.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Data
{
    class Repository : IRepository
    {
        //Товары

        private List<Product> _products = new List<Product>();
        public IEnumerable<Product> GetProductsFromJSON()
        {
            //DESERILIZATION
            if (!File.Exists("Данные магазина.json"))
            {
                return null;
            }
            
            using (var f = File.OpenText("Данные магазина.json"))
            {
                var json = f.ReadToEnd();
                _products = JsonConvert.DeserializeObject<List<Product>>(json,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                return _products;
            }    
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
            
        }

        public void RemoveProduct(int id)
        {
            var product = _products.FirstOrDefault(d => d.Id == id);

            if(product != null)
            {
                _products.Remove(product);

            }
            
        }

        //Поставщики

        private  List<Provider> _provider = new List<Provider>();

        public IEnumerable<Provider> GetProviders()
        {
            if (!File.Exists("Поставщики.json"))
            {
                return null;
            }

            using (var f = File.OpenText("Поставщики.json"))
            {
                var json = f.ReadToEnd();
                _provider = JsonConvert.DeserializeObject<List<Provider>>(json,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                return _provider;
            }
        }

        public IEnumerable<Provider> GetAllProviders()
        {
            return _provider;
        }
        
        public void AddProvider(Provider provider)
        {
            _provider.Add(provider);
        }

        public void RemoveProvider(int id)
        {
            var provider = _provider.FirstOrDefault(d => d.Id == id);

            if (provider != null)
            {
                _provider.Remove(provider);
            }
        }

        private List<SoldProductsStatistic> _soldProducts = new List<SoldProductsStatistic>();

        //Статистика

        public IEnumerable<SoldProductsStatistic> GetAllStatisticList()
        {
            if (!File.Exists("Статистика.json"))
            {
                return null;
            }

            using (var f = File.OpenText("Статистика.json"))
            {
                var json = f.ReadToEnd();
                _soldProducts = JsonConvert.DeserializeObject<List<SoldProductsStatistic>>(json,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                return _soldProducts;
            }
        }

        public IEnumerable<SoldProductsStatistic> GetStatistics()
        {
            return _soldProducts;
        }

        public void AddSoldProduct(SoldProductsStatistic soldProducts)
        {
            
            _soldProducts.Add(soldProducts);
        }


        
    }
}
