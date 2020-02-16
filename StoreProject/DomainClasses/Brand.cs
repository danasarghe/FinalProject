using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class Brand
    {
        [Key]
        [Column(Order = 0)]
        public int Brandid { get; set; }
        [Column(Order = 1)]
        public string Name { get; set; }
    }
}
