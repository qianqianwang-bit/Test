using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace Eshop.Models
{
    public class EshopDBContext:DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}