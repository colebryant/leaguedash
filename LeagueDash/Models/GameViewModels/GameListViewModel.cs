using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models.GameViewModels
{
    public class GameListViewModel
    {
        public List<GameDetailsViewModel> GameList { get; set; }

        public int CurrentUserRoleId { get; set; }
    }
}
