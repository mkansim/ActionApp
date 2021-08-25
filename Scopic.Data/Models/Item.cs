using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scopic.Data.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Sold { get; set; }
        public double ListPrice { get; set; }
    }
}