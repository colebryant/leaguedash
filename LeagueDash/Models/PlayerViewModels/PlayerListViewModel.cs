using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models.PlayerViewModels
{
    public class PlayerListViewModel
    {
        public List<PlayerDetailsViewModel> PlayerList { get; set; }
    }
}
