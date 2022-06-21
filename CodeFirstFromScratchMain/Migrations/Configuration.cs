namespace CodeFirstFromScratchMain.Migrations
{
    using CodeFirstFromScratchMain.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstFromScratchMain.DAL.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstFromScratchMain.DAL.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var products = new List<Product>()
            {
                    new Product
                    {
                        ID = 1,
                        Name ="Kit Kat",
                        Description ="Chocolate Bar",
                        Price = 3.3M,
                        Category = new Category()
                        {
                            Name="Sweets",
                            Description = "Full Sugar"
                        }
                    }
            };
            products.ForEach(p => context.Products.AddOrUpdate(p));
            context.SaveChanges();
        }
    }
}
