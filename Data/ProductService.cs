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
                new Product { Id = 7, ImageUrl = "/images/movie2.png", Title = "Baumer 베리센서", Content = "20년 이상 PC 기반 화상 처리 시스템을 위한 고성능 디지털\r\n카메라 및 직관적인 비전센서", Category = "Components", SubCategory = "MachineVision", SubSubCategory = "3D Camera" },
                new Product { Id = 8, ImageUrl = "/images/movie3.png", Title = "Wenglor 3D 센서", Content = "30년 이상의 경험과 2만개 이상의 설치된 솔루션을 통해 3차\r\n원 물체의 표면과 부피 프로파일을 빠르고 정확하게 계산할 수\r\n있다. ", Category = "Components", SubCategory = "MachineVision", SubSubCategory = "3D Camera" },
                new Product { Id = 9, ImageUrl = "/images/movie4.png", Title = "JAI 라인스캔카메라", Content = "색상 정확도, 감광도, 빠른 라인 속도, 사용 편의성 및 다중 스\r\n펙트럼 옵션을 결합한 고성능 프리즘 기반 컬러 라인 스캔 카\r\n메라 입니다.", Category = "Components", SubCategory = "MachineVision", SubSubCategory = "3D Camera" },
                new Product { Id = 10, ImageUrl = "/images/movie7.png", Title = "화이버센서와 앰프", Content = "고출력을 기반으로 자동 감도 추적기능을 이용하여 손쉽고\r\n빠르게 정할 수 있습니다.", Category = "Components", SubCategory = "Sensors", SubSubCategory = "2D Camera" },
                new Product { Id = 11, ImageUrl = "/images/movie1.png", Title = "Sensor Title 2", Content = "Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2Sensor Content 2", Category = "Components", SubCategory = "Sensors", SubSubCategory = "2D Camera" },
                new Product { Id = 12, ImageUrl = "/images/movie2.png", Title = "Sensor Title 3", Content = "Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3Sensor Content 3", Category = "Components", SubCategory = "Sensors", SubSubCategory = "2D Camera" },
                new Product { Id = 13, ImageUrl = "/images/movie1.png", Title = "MV Con1 Product 1", Content = "MV Con1 Content 1", Category = "Components", SubCategory = "MachineVision", SubSubCategory = "Confocal" },
                new Product { Id = 14, ImageUrl = "/images/movie2.png", Title = "MV Con2 Product 1", Content = "MV Con2 Content 1", Category = "Components", SubCategory = "MachineVision", SubSubCategory = "Confocal" },
                new Product { Id = 15, ImageUrl = "/images/movie3.png", Title = "MV Con3 Product 1", Content = "MV Con3 Content 1", Category = "Components", SubCategory = "MachineVision", SubSubCategory = "Confocal" },
                new Product { Id = 16, ImageUrl = "/images/movie4.png", Title = "Sensors Con1 Product 1", Content = "Sensors Con1 Content 1", Category = "Components", SubCategory = "Sensors", SubSubCategory = "3D Camera" },
                new Product { Id = 17, ImageUrl = "/images/movie5.png", Title = "Sensors Con2 Product 1", Content = "Sensors Con2 Content 1", Category = "Components", SubCategory = "Sensors", SubSubCategory = "3D Camera" },
                new Product { Id = 18, ImageUrl = "/images/movie6.png", Title = "Sensors Con3 Product 1", Content = "Sensors Con3 Content 1", Category = "Components", SubCategory = "Sensors", SubSubCategory = "3D Camera" },
            };
        }    
        //Components 항목 get
        public List<Product> GetTopProducts(string category, string subCategory, string subSubCategory, int count = 3)
        {
            return _products
                .Where(p => p.Category == category && p.SubCategory == subCategory && p.SubSubCategory == subSubCategory)
                .Take(count)
                .ToList();
        }
        //S/I 항목 get
        public List<Product> GetAllProducts(string category, string subCategory)
        {
            return _products
                .Where(p => p.Category == category && p.SubCategory == subCategory)
                .ToList();
        }

        public async Task<WEBB.Models.Product> GetProductById(int id)
        {
            await Task.Delay(100);
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}