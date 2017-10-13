using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GummiBearKingdom.Models
{
    public class Post
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Author { get; set; }
        [Required]
        public string TextBody { get; set; }
        [Required]
        public string Topic { get; set; }
        public DateTime PostDate { get; set; }

        public Post()
        {
            this.PostDate = DateTime.Now;
        }
    }
}
