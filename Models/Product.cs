using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WEBB.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("Id")]
        public int Id { get; set; }

        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string SubSubCategory { get; set; }

        // ... 기존의 다른 속성들

        [BsonIgnore]
        public string ShortContent
        {
            get
            {
                if (Content?.Length <= 30)
                    return Content;
                return Content?.Substring(0, 30) + "...";
            }
        }

        [BsonIgnore]
        public string MiddleContent
        {
            get
            {
                if (Content?.Length <= 200)
                    return Content;
                return Content?.Substring(0, 200) + "...";
            }
        }

        [BsonIgnore]
        public string ShortTitle
        {
            get
            {
                if (Title?.Length <= 30)
                    return Title;
                return Title?.Substring(0, 30) + "...";
            }
        }
    }
}