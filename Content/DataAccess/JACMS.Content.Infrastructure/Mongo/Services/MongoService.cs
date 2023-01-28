using JACMS.Content.Core.Services.Abstractions;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.Mongo.Services
{
    public class MongoService<T> : IMongoService<T>
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _db;
        private readonly IMongoCollection<T> _collection;
        public MongoService(string connectionString, string db, string collection)
        {
            _client = new MongoClient(connectionString);
            _db = _client.GetDatabase(db);
            _collection = _db.GetCollection<T>(collection);

        }

        public void Create(T newObject)
        {
            _collection.InsertOne(newObject);
        }

        public void Delete(Expression<Func<T,bool>> deleteExpression)
        {
            _collection.DeleteOne<T>(deleteExpression);
        }

        public dynamic Get(Expression<Func<T, bool>> getExpression, bool isSingle = true)
        {
            var results = _collection.Find(getExpression);
            if (isSingle)
            {
                return results.FirstOrDefault();
            }
            else
            {
                return results.ToList();
            }
        }

        public void Update(Expression<Func<T,bool>> updateExpression, T updateObject)
        {
            _collection.ReplaceOne<T>(updateExpression, updateObject);
        }
    }
}
