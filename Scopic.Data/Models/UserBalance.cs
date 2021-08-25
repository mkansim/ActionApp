using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scopic.Data.Models
{
    public class UserBalance
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double CurrentBalance { get; set; }
    }
}