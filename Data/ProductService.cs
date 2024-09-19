using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBB.Models;

namespace WEBB.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> AddProductAsync(Product product);
        Task<Product> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(int id);
    }

    public class ProductService : IProductService
    {
        private List<Product> _products;

        public ProductService()
        {
            // 샘플 데이터 초기화
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "제품 A", ShortDescription = "훌륭한 제품 A입니다.", Price = 19.99m, ImageUrl = "/images/product-a.jpg" },
                new Product { Id = 2, Name = "제품 B", ShortDescription = "놀라운 제품 B입니다.", Price = 29.99m, ImageUrl = "/images/product-b.jpg" },
                new Product { Id = 3, Name = "제품 C", ShortDescription = "혁신적인 제품 C입니다.", Price = 39.99m, ImageUrl = "/images/product-c.jpg" },
            };
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            // 비동기 작업을 시뮬레이션합니다
            await Task.Delay(100);
            return _products;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            await Task.Delay(50);
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            await Task.Delay(100);
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            await Task.Delay(100);
            var existingProduct = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.ShortDescription = product.ShortDescription;
                existingProduct.Price = product.Price;
                existingProduct.ImageUrl = product.ImageUrl;
            }
            return existingProduct;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            await Task.Delay(100);
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
                return true;
            }
            return false;
        }
    }
}