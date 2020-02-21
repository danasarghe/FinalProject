using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ModelsClasses
{
    [Table("Brand")]
    public class Brand
    {
        [Key]
        public int Brandid { get; set; }

        public string Name { get; set; }
    }

    [Table("Genre")]
    public class Genre
    {
        [Key]
        [Column("GenreId", Order = 0)]
        public int Genreid { get; set; }
        [Column(Order = 1)]
        public string Name { get; set; }

        [Column(Order = 2)]
        public string Description { get; set; }
        public List<Product> Products { get; set; }

    }

    [Table("Product")]
    public class Product
    {
        
        [Key]
        [Column(Order = 0)]
        public int Productid { get; set; }
        [Column(Order = 1)]
        public int Genreid { get; set; }
        [Column(Order = 2)]
        public int Brandid { get; set; }
        [Column(Order = 3)]
        public string Title { get; set; }
        [Column(Order = 4)]
        public decimal Price { get; set; }
        [Column(Order = 5)]
        public int Size { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Brand Brand { get; set; }

    }

    [Table("Order")]
    public class Order
    {
        [Key]
        [Column(Order = 0)]
        public int Orderid { get; set; }
        [Column(Order = 12)]
        public DateTime OrderDate { get; set; }
        [Column(Order = 1)]
        public string UserName { get; set; }
        [Column(Order = 2)]
        public string FirstName { get; set; }
        [Column(Order = 3)]
        public string LastName { get; set; }
        [Column(Order = 4)]
        public string Adress { get; set; }
        [Column(Order = 5)]
        public string City { get; set; }
        [Column(Order = 6)]
        public string PostalCode { get; set; }
        [Column(Order = 7)]
        public string Country { get; set; }
        [Column(Order = 8)]
        public string Email { get; set; }
        [Column(Order = 9)]
        public string Phone { get; set; }
        [Column(Order = 10)]
        public decimal Total { get; set; }
        
        public List<OrderDetail> OrderDetails { get; set; }

    }

    [Table("OrderDetail")]

    public class OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        public int OrderDetailid { get; set; }
        [Column(Order = 1)]
        public int Orderid { get; set; }
        [Column(Order = 2)]
        public int Productid { get; set; }
        [Column(Order = 3)]
        public int Quantity { get; set; }
        [Column(Order = 4)]
        public decimal UnitPrice { get; set; }
       
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
    [Table("Cart")]

    public class Cart
    {
        [Key]
        [Column(Order = 0)]
        public int Recordid { get; set; }
        [Column(Order = 1)]
        public int CartId { get; set; }
        [Column(Order = 2)]
        public int ProductId { get; set; }
        [Column(Order = 3)]
        public int Count { get; set; }
        
        public virtual Product Product { get; set; }
    }

    [Table("User")]
    public class User
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        [Column(Order = 1)]
        public string UserName { get; set; }
        [Column(Order = 2)]
        public string Email { get; set; }
        [Column(Order = 3)]
        public string Description { get; set; }
       

        public enum Role
        {
            Guest = 1,
            User = 2,
            Admin = 3

        }
    }
}
