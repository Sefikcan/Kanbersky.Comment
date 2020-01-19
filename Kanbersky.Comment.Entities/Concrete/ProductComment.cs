using Kanbersky.Comment.Core.Entities;
using Kanbersky.Comment.Entities.Abstract;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Kanbersky.Comment.Entities.Concrete
{
    public class ProductComment : BaseEntity,IEntity
    {
        [BsonElement("ProductId")]
        [BsonRepresentation(BsonType.Int32)]
        public int ProductId { get; set; }

        [BsonElement("Author")]
        [BsonRepresentation(BsonType.String)]
        public string Author { get; set; }

        [BsonElement("Description")]
        [BsonRepresentation(BsonType.String)]
        public string Description { get; set; }

        [BsonElement("Rating")]
        [BsonRepresentation(BsonType.Int32)]
        public int Rating { get; set; }
    }
    //Ek Bilgi
    //BsonElement MongoDB tarafında, collection’ın property’sini isimlendirmek amacıyla kullanılan bir attribute.
}
