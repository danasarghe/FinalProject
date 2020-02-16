using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
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
}
