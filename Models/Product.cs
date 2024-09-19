using System.ComponentModel.DataAnnotations;

namespace WEBB.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ShortDescription { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "가격은 0 이상이어야 합니다.")]
        public decimal Price { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }
    }
}