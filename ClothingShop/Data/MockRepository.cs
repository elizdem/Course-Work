using ClothingShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClothingShop.Data
{
    class MockRepository : IRepository
    {
        private readonly List<Product> _products = new List<Product>()
        {
            new Product
            {
                Id=1,
                Name="N-Shirt",
                Article=12345,
                Cost=1000,
                Brand="Bershka",
                Size=44,
                Type="Women"

            },
            new Product
            {
                Id=2,
                Name="Blouse",
                Article=456253,
                Cost=1050,
                Brand="H&M",
                Size=48,
                Type="Men"
            },
            new Product
            {
                Id=3,
                Name="Tight",
                Article=679247,
                Cost=500,
                Brand="Zara",
                Size=50,
                Type="Women"
            },
            new Product
            {
                Id=4,
                Name="Trousers",
                Article=589754,
                Cost=2000,
                Brand="Stradivarius",
                Size=46,
                Type="Men"
            },
            new Product
            {
                Id=5,
                Name="Ring",
                Article=5787454,
                Cost=450,
                Brand="Zarina",
                Size=18,
                Type="Women"
            },
            new Product
            {
                Id=1,
                Name="Sweater",
                Article=6548975,
                Cost=2500,
                Brand="Your",
                Size=48,
                Type="Women"
            }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public IEnumerable<Product> GetProductsFromJSON()
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

            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public void MakeOrder(int article)
        {
            var product = _products.Where(p => p.Article == article);

        }


        private readonly List<Provider> _providers = new List<Provider>()        
        {
            new Provider
            {
                Id=1,
                FirstName = "Ivanov",
                LastName = "Ivan",
                CompanyName = "SevStar",
                TelNumber = 79785056982,
                Email = "ivanov@gmail.com"
            },

            new Provider
            {
                Id=2,
                FirstName = "Sidorov",
                LastName = "Alexander",
                CompanyName = "BlaBla",
                TelNumber = 79785065712,
                Email = "sidorov@gmail.com"
            },

            new Provider
            {
                Id = 2,
                FirstName = "Petrov",
                LastName = "Pavel",
                CompanyName = "BlaBlaBlaBla",
                TelNumber = 79757482763,
                Email = "petrov@gmail.com"
            },

            new Provider
            {
                Id = 2,
                FirstName = "Smirnov",
                LastName = "Petr",
                CompanyName = "Trulala",
                TelNumber = 797574288429,
                Email = "smirnov@gmail.com"
            }

        };


        public IEnumerable<Provider> GetProviders()
        {
            return _providers;
        }

        public IEnumerable<Provider> GetAllProviders()
        {
            return _providers;
        }

        public void AddProvider(Provider provider)
        {
            _providers.Add(provider);
        }

        public void RemoveProvider(int id)
        {
            var provider = _providers.FirstOrDefault(d => d.Id == id);

            if (provider != null)
            {
                _providers.Remove(provider);
            }
        }
        // Stat
        private readonly List<SoldProductsStatistic> _soldProductStatistic = new List<SoldProductsStatistic>();
        //{
        //    new SoldProductsStatistic
        //    {
        //        Sum=1055,
        //        Date=DateTime.Now
        //    },

        //    new SoldProductsStatistic
        //    {
        //        Sum = 1345,
        //        Date= DateTime.Now
        //    }
        //};

        public IEnumerable<SoldProductsStatistic> GetStatistics()
        {
            return _soldProductStatistic;
        }

        public void AddSoldProduct(SoldProductsStatistic soldProducts)
        {
            _soldProductStatistic.Add(soldProducts);
        }

        public IEnumerable<SoldProductsStatistic> GetAllStatisticList()
        {
            return _soldProductStatistic;
        }

    }
}
