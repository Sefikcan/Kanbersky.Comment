using Kanbersky.Comment.Core.Helpers.Models;
using Kanbersky.Comment.Entities.Concrete;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Kanbersky.Comment.DAL.Concrete.MongoDB.Context
{
    public class CommentContext
    {
        #region fields

        private MongoClient _mongoClient;
        private readonly IMongoDatabase _database;

        #endregion

        #region ctor

        public CommentContext(IOptions<AppSettings> settings)
        {
            _mongoClient = new MongoClient(settings.Value.ConnectionString);
            _database = _mongoClient.GetDatabase(settings.Value.Database); 
        }

        #endregion

        #region dbset

        public IMongoCollection<ProductComment> ProductComments => _database.GetCollection<ProductComment>("ProductComments");

        #endregion
    }
}
