using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
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
}
