using ModelsClasses;
using System.Data.Entity;

namespace DataModel
{
    public partial class StoreContext : DbContext
    {

        public StoreContext() : base("StoreDbConnexionString")
        {
            Database.SetInitializer<StoreContext>(new DropCreateDatabaseAlways<StoreContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreContext, DataModel.Migrations.Configuration>());

        }



        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure default schema
            modelBuilder.HasDefaultSchema("Admin");

            //Map entity to table
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Genre>().ToTable("Genre", "dbo");
            modelBuilder.Entity<Brand>().ToTable("Brand", "dbo");
            modelBuilder.Entity<Cart>().ToTable("Cart", "dbo");
            modelBuilder.Entity<Order>().ToTable("Order", "dbo");
            modelBuilder.Entity<OrderDetail>().ToTable("OrderDetail", "dbo");
            modelBuilder.Entity<User>().ToTable("User", "dbo");
        }
    }
}
