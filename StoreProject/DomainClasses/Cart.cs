using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
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
}
