namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateIndex("Admin.Product", "Genreid");
            CreateIndex("Admin.Product", "Brandid");
            AddForeignKey("Admin.Product", "Brandid", "dbo.Brand", "Brandid", cascadeDelete: true);
            AddForeignKey("Admin.Product", "Genreid", "dbo.Genre", "GenreId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Admin.Product", "Genreid", "dbo.Genre");
            DropForeignKey("Admin.Product", "Brandid", "dbo.Brand");
            DropIndex("Admin.Product", new[] { "Brandid" });
            DropIndex("Admin.Product", new[] { "Genreid" });
        }
    }
}
