using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesPlayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorPagesPlayer.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesPlayerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesPlayerContext>>()))
            {
                // Look for any movies.
                if (context.Player.Any())
                {
                    return;   // DB has been seeded
                }

                context.Player.AddRange(
                    new Player
                    {
                        Name = "Showmaker",
                        Age = 21,
                        Team = "Damwon Gaming KIA",
                        Role = "Middle",
                        KDA = 6.3M,
                    },

                    new Player
                    {
                        Name = "Inspired",
                        Age = 19,
                        Team = "Rogue",
                        Role = "Jungle",
                        KDA = 4.0M,
                    },

                    new Player
                    {
                        Name = "Carzzy",
                        Age = 19,
                        Team = "MAD Lions",
                        Role = "Bottom",
                        KDA = 3.9M,
                    },

                    new Player
                    {
                        Name = "Xiaohu",
                        Age = 23,
                        Team = "Royal Never Give Up",
                        Role = "Top",
                        KDA = 3.7M,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
