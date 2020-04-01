using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class DBContext<T> where T : class
    {
        private IMongoDatabase _database = null;
        public DBContext(DBSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Database);
            }
        }

        public IMongoCollection<T> Collection(string collection)
        {
                return _database.GetCollection<T>(collection);
        }
    }

}
