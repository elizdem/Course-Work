using ClothingShop.Data;
using ClothingShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Services
{
    class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork = new UnitOfWork();
        private readonly IRepository _repository;

        public ProductService()
        {
            _repository = _unitOfWork.Repository;
        }
        public IEnumerable<Product> GetProductsFromJSON()
        {
            return _repository.GetProductsFromJSON();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public void AddProduct(Product product)
        {
           _repository.AddProduct(product);
           _unitOfWork.SaveChanges();
        }

        public IEnumerable<Product> GetProductsByArticle(int article)
        {
            List<Product> filteredProducts = GetProductsFromJSON().ToList().Where(p => p.Article == article).ToList();
            return filteredProducts;
        }
        

        public void EditProduct(int id)
        {

        }

        public void RemoveProduct(int id)
        {
            _repository.RemoveProduct(id);
            _unitOfWork.SaveChanges();
        }

    }
}
