using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
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
}
