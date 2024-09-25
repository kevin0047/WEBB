using System.Collections.Generic;
using System.Linq;
using WEBB.Models;

namespace WEBB.Data
{
    public class ProductService
    {
        private List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, ImageUrl = "/images/movie1.png", Title = "Machine Vision Title 1", Content = "Machine Vision Content 1Machine Vision Content 1Machine Vision Content 1Machine Vision Content 1Machine Vision Content 1Machine Vision Content 1Machine Vision Content 1Machine Vision Content 1Machine Vision Content 1Machine Vision Content 1", Category = "S/I", SubCategory = "MachineVision" },
                new Product { Id = 2, ImageUrl = "/images/movie2.png", Title = "Machine Vision Title 2", Content = "Machine Vision Content 2Machine Vision Content 2Machine Vision Content 2Machine Vision Content 2Machine Vision Content 2Machine Vision Content 2Machine Vision Content 2Machine Vision Content 2Machine Vision Content 2", Category = "S/I", SubCategory = "MachineVision" },
                new Product { Id = 3, ImageUrl = "/images/movie3.png", Title = "Machine Vision Title 3", Content = "Machine Vision Content 3Machine Vision Content 3Machine Vision Content 3Machine Vision Content 3Machine Vision Content 3Machine Vision Content 3Machine Vision Content 3Machine Vision Content 3", Category = "S/I", SubCategory = "MachineVision" },
                new Product { Id = 4, ImageUrl = "/images/movie4.png", Title = "Automatic Control Title 1", Content = "Automatic Control Content 1Automatic Control Content 1Automatic Control Content 1Automatic Control Content 1Automatic Control Content 1Automatic Control Content 1Automatic Control Content 1Automatic Control Content 1Automatic Control Content 1Automatic Control Content 1Automatic Control Content 1", Category = "S/I", SubCategory = "AutomaticControl" },
                new Product { Id = 5, ImageUrl = "/images/movie5.png", Title = "Automatic Control Title 2", Content = "Automatic Control Content 2Automatic Control Content 2Automatic Control Content 2Automatic Control Content 2Automatic Control Content 2Automatic Control Content 2Automatic Control Content 2Automatic Control Content 2Automatic Control Content 2", Category = "S/I", SubCategory = "AutomaticControl" },
                new Product { Id = 6, ImageUrl = "/images/movie1.png", Title = "Automatic Control Title 3", Content = "Automatic Control Content 3Automatic Control Content 3Automatic Control Content 3Automatic Control Content 3Automatic Control Content 3Automatic Control Content 3Automatic Control Content 3Automatic Control Content 3Automatic Control Content 3Automatic Control Content 3Automatic Control Content 3Automatic Control Content 3", Category = "S/I", SubCategory = "AutomaticControl" },
                new Product { Id = 7, ImageUrl = "/images/movie2.png", Title = "Machine Vision Component Title 1", Content = "Machine Vision Component Content 1Machine Vision Component Content 1Machine Vision Component Content 1Machine Vision Component Content 1Machine Vision Component Content 1Machine Vision Component Content 1Machine Vision Component Content 1", Category = "Components", SubCategory = "MachineVision" },
                new Product { Id = 8, ImageUrl = "/images/movie3.png", Title = "Machine Vision Component Title 2", Content = "Machine Vision Component Content 2Machine Vision Component Content 2Machine Vision Component Content 2Machine Vision Component Content 2Machine Vision Component Content 2Machine Vision Component Content 2Machine Vision Component Content 2Machine Vision Component Content 2Machine Vision Component Content 2Machine Vision Component Content 2", Category = "Components", SubCategory = "MachineVision" },
                new Product { Id = 9, ImageUrl = "/images/movie4.png", Title = "Machine Vision Component Title 3Machine Vision Component Title 3Machine Vision Component Title 3Machine Vision Component Title 3Machine Vision Component Title 3Machine Vision Component Title 3Machine Vision Component Title 3Machine Vision Component Title 3Machine Vision Component Title 3", Content = "Machine Vision Component Content 3Machine Vision Component Content 3Machine Vision Component Content 3Machine Vision Component Content 3Machine Vision Component Content 3Machine Vision Component Content 3Machine Vision Component Content 3Machine Vision Component Content 3Machine Vision Component Content 3Machine Vision Component Content 3", Category = "Components", SubCategory = "MachineVision" },
                new Product { Id = 10, ImageUrl = "/images/movie5.png", Title = "Sensor Title 1", Content = "Sensor Content 1Sensor Content 1Sensor Content 1Sensor Content 1Sensor Content 1Sensor Content 1Sensor Content 1Sensor Content 1Sensor Content 1Sensor Content 1Sensor Content 1", Category = "Components", SubCategory = "Sensors" },
                new Product { Id = 11, ImageUrl = "/images/movie1.png", Title = "Sensor Title 2", Content = "Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2", Category = "Components", SubCategory = "Sensors" },
                new Product { Id = 12, ImageUrl = "/images/movie2.png", Title = "Sensor Title 3", Content = "Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3", Category = "Components", SubCategory = "Sensors" },
            };
        }

        public List<Product> GetTopProducts(string category, string subCategory, int count = 3)
        {
            return _products
                .Where(p => p.Category == category && p.SubCategory == subCategory)
                .Take(count)
                .ToList();
        }

        public List<Product> GetAllProducts(string category, string subCategory)
        {
            return _products
                .Where(p => p.Category == category && p.SubCategory == subCategory)
                .ToList();
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}