using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using WEBB.Models;
using MongoDB.Bson;

namespace WEBB.Data
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _products;

        public ProductService(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("MongoDb"));
            var database = client.GetDatabase(configuration["DatabaseSettings:DatabaseName"]);
            _products = database.GetCollection<Product>(configuration["DatabaseSettings:ProductsCollectionName"]);
        }

        public List<Product> GetTopProducts(string category, string subCategory, string subSubCategory)
        {
            return _products.Find(p =>
                p.Category == category &&
                p.SubCategory == subCategory &&
                p.SubSubCategory == subSubCategory)
                .SortByDescending(p => p.Id)

                .ToList();
        }

        public List<Product> GetAllProducts(string category, string subCategory)
        {
            return _products.Find(p =>
                p.Category == category &&
                p.SubCategory == subCategory)
               .SortByDescending(p => p.Id)
                .ToList();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _products.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddProduct(Product product)
        {
            var lastProduct = await _products.Find(_ => true)
                .SortByDescending(p => p.Id)
                .Limit(1)
                .FirstOrDefaultAsync();

            product.Id = (lastProduct?.Id ?? 0) + 1;
            product._id = ObjectId.GenerateNewId().ToString();
            await _products.InsertOneAsync(product);
        }
    }
}