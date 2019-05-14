using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models.GameViewModels
{
    public class GameDetailsViewModel
    {
        public Game Game { get; set; }

        [Display(Name = "Team A")]
        public string TeamAName { get; set; }

        [Display(Name = "Team B")]
        public string TeamBName { get; set; }

        public string GDate
        {
            get
            {
                return Game.GameTime.ToString("M/d/yyyy");
            }
        }

        public string GTime
        {
            get
            {
                return Game.GameTime.ToString("h:mm tt");
            }
        }

        public ApplicationUser CurrentUser { get; set; }
    }
}
