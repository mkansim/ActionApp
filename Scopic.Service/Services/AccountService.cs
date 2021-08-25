using Scopic.Data.Context;
using Scopic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Scopic.Service.Services
{
   
    public class AccountService : IAccountService
    {
        private readonly DatabaseContext _database;
        public AccountService(DatabaseContext database)
        {
            _database = database;
        }
        public  User GetUser(int id)
        {
            return _database.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public User Login(string username, string password)
        {
            var user = _database.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            return user;
        }
    }
}