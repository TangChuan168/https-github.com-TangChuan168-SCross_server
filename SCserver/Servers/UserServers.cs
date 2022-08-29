using MongoDB.Driver;
using SCserver.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCserver.Servers
{
    public class UserServers
    {
        private readonly Repository _repo;
        public UserServers(
        Repository UserRepo
            )
        {
            _repo = UserRepo;
        }

        public userInfo SearchUser(string u1)
        {
            return  _repo.getUserBYnumber(u1);
           
            
        }
    }
}
