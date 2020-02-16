using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses;

namespace DomainData
{
    public class StoreContext : DbContext
    {

        public StoreContext() : base("StoreConnexionString")
        {
            Database.SetInitializer<StoreContext>(new DropCreateDatabaseAlways<StoreContext>());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreContext, DomainData.Migrations.Configuration>());

        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure default schema
            //modelBuilder.HasDefaultSchema("Admin");

            //Map entity to table
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Genre>().ToTable("Genre", "dbo");
            modelBuilder.Entity<Brand>().ToTable("Brand", "dbo");
            modelBuilder.Entity<Cart>().ToTable("Cart", "dbo");
            modelBuilder.Entity<Order>().ToTable("Order", "dbo");
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail", "dbo");

        }

    }

}
