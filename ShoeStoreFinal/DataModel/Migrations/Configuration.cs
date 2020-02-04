namespace DataModel.Migrations
{
    using ModelsClasses;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataModel.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataModel.StoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var brand = new Brand
            {
                Brandid = 1,
                Name = "Adidas"

            };

            context.Brands.AddOrUpdate(x => x.Brandid, brand);

            var order = new Order
            {
                Orderid = 1,
                UserName = "gsfgfr",
                FirstName = "gigi",
                LastName = "kent",
                Adress = "Str.Mare",
                City = "Iasi",
                PostalCode = "70250",
                Country = "Romania",
                Email = "dhuhr@gmail.com",
                Phone = "0700000000",
                Total = 250,
                OrderDate = DateTime.Now
               
                
            };
            context.Orders.AddOrUpdate(x => x.Orderid, order);

            var product = new Product
            {
                Productid = 1,
                Genreid = 3,
                Brandid = 4,
                Title = "Casual",
                Price = 69,
                Size = 37


            };
            context.Products.AddOrUpdate(x => x.Productid, product);

            var orderDetails = new OrderDetail
            {
                OrderDetailid = 1,
                Orderid = 2,
                Productid = 1,
                Quantity = 2,
                UnitPrice = 56
            };
            context.OrderDetails.AddOrUpdate(x => x.OrderDetailid, orderDetails);
        }
    }
}
