using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DevExtremeMvcApp1.Models
{
    public class AppContext : DbContext
    {
        public DbSet<County> Counties { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}