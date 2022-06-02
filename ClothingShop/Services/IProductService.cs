using ClothingShop.Entities;
using System.Collections.Generic;

namespace ClothingShop.Services
{
    interface IProductService
    {
        IEnumerable<Product> GetAllProducts();

        void AddProduct(Product product);
        void EditProduct(int id);
        void RemoveProduct(int id);
        IEnumerable<Product> GetProductsByArticle(int article);
        IEnumerable<Product> GetProductsFromJSON();
    }
}