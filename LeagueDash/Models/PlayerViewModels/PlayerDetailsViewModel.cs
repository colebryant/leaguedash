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

        public string PlayerTeam { get; set; }

        [Display(Name = "Player Name")]
        public string FullName
        {
            get
            {
                return $"{Player.FirstName} {Player.LastName}";
            }
        }
    }
}
