using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Shopping.API.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public string Category { get; internal set; }
        public string Description { get; internal set; }
        public string ImageFile { get; internal set; }
        public decimal Price { get; internal set; }
    }
}
