namespace PlusAndComment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CCC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryEntity",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CategoryEntity", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
            CreateTable(
                "dbo.FilterEntity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ValueFrom = c.Double(nullable: false),
                        ValueTo = c.Double(nullable: false),
                        Unit = c.Double(nullable: false),
                        ProductEntity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductEntity", t => t.ProductEntity_Id)
                .Index(t => t.ProductEntity_Id);
            
            CreateTable(
                "dbo.ProductEntity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Header = c.String(),
                        DescriptionLong = c.String(),
                        DescriptionShort = c.String(),
                        BuyDateTime = c.DateTime(nullable: false),
                        AddedDateTime = c.DateTime(nullable: false),
                        FilterEntity_ID = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoryEntity", t => t.Category_Id, cascadeDelete: true)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilterEntity", "ProductEntity_Id", "dbo.ProductEntity");
            DropForeignKey("dbo.ProductEntity", "Category_Id", "dbo.CategoryEntity");
            DropForeignKey("dbo.CategoryEntity", "Category_ID", "dbo.CategoryEntity");
            DropIndex("dbo.ProductEntity", new[] { "Category_Id" });
            DropIndex("dbo.FilterEntity", new[] { "ProductEntity_Id" });
            DropIndex("dbo.CategoryEntity", new[] { "Category_ID" });
            DropTable("dbo.ProductEntity");
            DropTable("dbo.FilterEntity");
            DropTable("dbo.CategoryEntity");
        }
    }
}
