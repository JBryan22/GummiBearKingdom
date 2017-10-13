using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Models
{
    public class GummiBearKingdomContext : DbContext
    {
        public GummiBearKingdomContext (DbContextOptions<GummiBearKingdomContext> options)
            : base(options)
        {
        }

        public DbSet<GummiBearKingdom.Models.Product> Product { get; set; }

        public DbSet<GummiBearKingdom.Models.Post> Post { get; set; }
    }
}
