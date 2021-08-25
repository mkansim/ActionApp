using Scopic.Data.Context;
using Scopic.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scopic.Service.Services
{
    public class UserBalanceService : IUserBalanceService
    {
        private readonly DatabaseContext _database;

        public UserBalanceService()
        {
            _database = new DatabaseContext();
        }
        public UserBalance GetUserBalance(int userId)
        {
            var balanceEntity = _database.UserBalances.Where(x => x.Id == userId).FirstOrDefault();

            return balanceEntity;
        }

        public UserBalance UpdateUserBalance(int userId, UserBalance userBalance)
        {

            var toUpdatedBalance = _database.UserBalances.Find(userId);
            if (toUpdatedBalance == null)
            {
                return null;
            }
            toUpdatedBalance.Id = userBalance.Id;
            toUpdatedBalance.CurrentBalance = userBalance.CurrentBalance;
            toUpdatedBalance.UserId = userBalance.UserId;
            _database.Entry(toUpdatedBalance).State = System.Data.Entity.EntityState.Modified;
            _database.SaveChanges();
            return toUpdatedBalance;


        }
    }
}