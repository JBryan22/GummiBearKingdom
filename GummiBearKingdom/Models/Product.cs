using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBearKingdom.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Range(0,999999999.99)]
        public decimal Cost { get; set; }
        [Required]
        [StringLength(100)]
        public string Country { get; set; }
    }
}
