using MongoDB.Bson.Serialization.Attributes;

namespace CasgemMicroservices.Services.Catalog.Models
{
    public class Product
    {
        [BsonId]
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public string ProductDescription { get; set; }
        public string CategoryID { get; set; }
        public Category  Category { get; set; }


    }
}
