using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesPlayer.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Team { get; set; }
        public string Role { get; set; }
        [Display(Name = "Kill/Death/Assist Ratio")]
        public decimal KDA { get; set; }
    }
}
