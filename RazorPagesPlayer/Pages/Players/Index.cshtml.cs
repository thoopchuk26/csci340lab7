using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesPlayer.Data;
using RazorPagesPlayer.Models;

namespace RazorPagesPlayer.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesPlayer.Data.RazorPagesPlayerContext _context;

        public IndexModel(RazorPagesPlayer.Data.RazorPagesPlayerContext context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Role { get; set; }
        [BindProperty(SupportsGet = true)]
        public string PlayerRole { get; set; }

        public async Task OnGetAsync()
        {
            var players = from m in _context.Player
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                players = players.Where(s => s.Role.Contains(SearchString));
            }

            Player = await players.ToListAsync();
        }
    }
}
