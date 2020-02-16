namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "Admin.Product", newSchema: "dbo");
            CreateIndex("dbo.Cart", "ProductId");
            CreateIndex("dbo.OrderDetail", "Orderid");
            CreateIndex("dbo.OrderDetail", "Productid");
            AddForeignKey("dbo.Cart", "ProductId", "dbo.Product", "Productid", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetail", "Orderid", "dbo.Order", "Orderid", cascadeDelete: true);
            AddForeignKey("dbo.OrderDetail", "Productid", "dbo.Product", "Productid", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetail", "Productid", "dbo.Product");
            DropForeignKey("dbo.OrderDetail", "Orderid", "dbo.Order");
            DropForeignKey("dbo.Cart", "ProductId", "dbo.Product");
            DropIndex("dbo.OrderDetail", new[] { "Productid" });
            DropIndex("dbo.OrderDetail", new[] { "Orderid" });
            DropIndex("dbo.Cart", new[] { "ProductId" });
            MoveTable(name: "dbo.Product", newSchema: "Admin");
        }
    }
}
