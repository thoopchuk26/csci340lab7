using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesPlayer.Models;

namespace RazorPagesPlayer.Data
{
    public class RazorPagesPlayerContext : DbContext
    {
        public RazorPagesPlayerContext (DbContextOptions<RazorPagesPlayerContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesPlayer.Models.Player> Player { get; set; }
    }
}
