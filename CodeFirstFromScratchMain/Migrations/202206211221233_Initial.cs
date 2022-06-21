namespace CodeFirstFromScratchMain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 244),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        CaregoryId = c.Int(nullable: false),
                        Category_CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryID)
                .Index(t => t.Category_CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_CategoryID" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
