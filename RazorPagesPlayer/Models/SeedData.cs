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
                        Name = "Canyon",
                        Age = 20,
                        Team = "Damwon Gaming KIA",
                        Role = "Mid",
                        KDA = 4.8M,
                    },
                    new Player
                    {
                        Name = "CoreJJ",
                        Age = 27,
                        Team = "Team Liquid",
                        Role = "Support",
                        KDA = 3.9M,
                    },
                    new Player
                    {
                        Name = "FBI",
                        Age = 2,
                        Team = "Team Liquid",
                        Role = "Bottom",
                        KDA = 4.4M,
                    },
                    new Player
                    {
                        Name = "Tarzan",
                        Age = 22,
                        Team = "LNG Esports",
                        Role = "Jungle",
                        KDA = 5.1M,
                    },
                    new Player
                    {
                        Name = "Nuguri",
                        Age = 22,
                        Team = "Fun Plus Pheonix",
                        Role = "Top",
                        KDA = 3.0M,
                    },
                    new Player
                    {
                        Name = "Gaeng",
                        Age = 25,
                        Team = "Detonation Focus Me",
                        Role = "Support",
                        KDA = 4.2M,
                    },
                    new Player
                    {
                        Name = "Unified",
                        Age = 22,
                        Team = "PSG Talon",
                        Role = "Support",
                        KDA = 9.4M,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
