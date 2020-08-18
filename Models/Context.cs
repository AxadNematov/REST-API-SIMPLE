using WebAPIDemo.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class Context : DbContext
    {
        public DbSet<itemsInBoxes> ItemsInBoxes { get; set; }
        public DbSet<OrdersModel> Orders { get; set; }
    }
}