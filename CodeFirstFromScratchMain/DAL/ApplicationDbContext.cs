using CodeFirstFromScratchMain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstFromScratchMain.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}