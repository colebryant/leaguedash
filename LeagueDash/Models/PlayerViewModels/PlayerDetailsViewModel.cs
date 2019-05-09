using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models.PlayerViewModels
{
    public class PlayerDetailsViewModel
    {
        public ApplicationUser Player { get; set; }

        [Display(Name = "Team")]
        public string PlayerTeam { get; set; }

        [Display(Name = "Preferred Position")]
        public string Position { get; set; }

        [Display(Name = "Player Name")]
        public string FullName
        {
            get
            {
                return $"{Player.FirstName} {Player.LastName}";
            }
        }

        public bool IsOnTeam { get; set; }
    }
}
