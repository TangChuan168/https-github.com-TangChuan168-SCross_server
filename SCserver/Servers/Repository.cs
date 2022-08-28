using MongoDB.Driver;
using SCserver.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCserver.Servers
{
    public class Repository
    {

        private readonly IMongoDatabase _database;

        private IMongoCollection<userInfo> _collection => _database.GetCollection<userInfo>("userInfo");
            
            //GetCollection<userInfo>("userInfo");

        public Repository(
        IMongoDatabase db
        )
        {
            _database = db;
        }

        public userInfo getUserBYnumber(string num)
        {
            return _collection.Find(x => x.policyNumber == num).FirstOrDefault();
            
        }


    }


}
