using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class DBSettings
    {
        public string ConnectionString = "mongodb://Admin:NOWcOoSqPrwxQ6LG@dbvintage-shard-00-00-v9ve1.mongodb.net:27017,dbvintage-shard-00-02-v9ve1.mongodb.net:27017/DBVintage?ssl=true&replicaSet=DBVintage-shard-0&authSource=admin&retryWrites=true&w=majority";
        public string Database = "DBVintage";
    }
}
