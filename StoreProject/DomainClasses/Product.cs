using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
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
}
