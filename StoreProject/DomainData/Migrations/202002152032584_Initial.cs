namespace DomainData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        Brandid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Brandid);
            
            CreateTable(
                "dbo.Cart",
                c => new
                    {
                        Recordid = c.Int(nullable: false, identity: true),
                        CartId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Recordid)
                .ForeignKey("dbo.Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Productid = c.Int(nullable: false, identity: true),
                        Genreid = c.Int(nullable: false),
                        Brandid = c.Int(nullable: false),
                        Title = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Productid)
                .ForeignKey("dbo.Brand", t => t.Brandid, cascadeDelete: true)
                .ForeignKey("dbo.Genre", t => t.Genreid, cascadeDelete: true)
                .Index(t => t.Genreid)
                .Index(t => t.Brandid);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        OrderDetailid = c.Int(nullable: false, identity: true),
                        Orderid = c.Int(nullable: false),
                        Productid = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailid)
                .ForeignKey("dbo.Order", t => t.Orderid, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.Productid, cascadeDelete: true)
                .Index(t => t.Orderid)
                .Index(t => t.Productid);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Orderid = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Adress = c.String(),
                        City = c.String(),
                        PostalCode = c.String(),
                        Country = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Orderid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetail", "Productid", "dbo.Product");
            DropForeignKey("dbo.OrderDetail", "Orderid", "dbo.Order");
            DropForeignKey("dbo.Cart", "ProductId", "dbo.Product");
            DropForeignKey("dbo.Product", "Genreid", "dbo.Genre");
            DropForeignKey("dbo.Product", "Brandid", "dbo.Brand");
            DropIndex("dbo.OrderDetail", new[] { "Productid" });
            DropIndex("dbo.OrderDetail", new[] { "Orderid" });
            DropIndex("dbo.Product", new[] { "Brandid" });
            DropIndex("dbo.Product", new[] { "Genreid" });
            DropIndex("dbo.Cart", new[] { "ProductId" });
            DropTable("dbo.Order");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Genre");
            DropTable("dbo.Product");
            DropTable("dbo.Cart");
            DropTable("dbo.Brand");
        }
    }
}
