namespace WEBB.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string ShortContent
        {
            get
            {
                if (Content.Length <= 30)
                    return Content;
                return Content.Substring(0, 30) + "...";
            }
        }
        public string ShortTitle
        {
            get
            {
                if (Title.Length <= 30)
                    return Title;
                return Title.Substring(0, 30) + "...";
            }
        }
    }
}