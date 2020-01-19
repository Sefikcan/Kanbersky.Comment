using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Kanbersky.Comment.Entities.Abstract
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedOn = DateTime.Now;
            ModifiedOn = DateTime.Now;
        }

        //ObjectId document primary key
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedOn { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime ModifiedOn { get; set; }
    }
}
