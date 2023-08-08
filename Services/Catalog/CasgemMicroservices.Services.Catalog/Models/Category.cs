using MongoDB.Bson.Serialization.Attributes;

namespace CasgemMicroservices.Services.Catalog.Models
{
    public class Category
    {
        [BsonId]
        public string  CategoryID { get; set; }
        public string  CategoryName { get; set; }
    }
}
