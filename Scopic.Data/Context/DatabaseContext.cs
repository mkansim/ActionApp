using Scopic.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Scopic.Data.Context
{
    public class DatabaseContext :  DbContext
    {
        public DatabaseContext() : base("name=dbconnection")
        {

        }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> ProductItems { get; set; }
        public DbSet<UserBalance> UserBalances { get; set; }
    }

}