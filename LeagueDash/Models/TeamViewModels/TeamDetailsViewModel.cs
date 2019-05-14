using LeagueDash.Models.PlayerViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models.TeamViewModels
{
    public class TeamDetailsViewModel
    {
        public Team Team { get; set; }

        public string Date
        {
            get
            {
                return Team.DateCreated.ToString("M/d/yyyy");
            }
        }

        public string TeamCaptainFirstName { get; set; }

        public string TeamCaptainLastName { get; set; }

        [Display(Name = "Team Captain")]
        public string TeamCaptain
        {
            get
            {
                return $"{TeamCaptainFirstName} {TeamCaptainLastName}";
            }
        }

        public ApplicationUser CurrentUser { get; set; }

        public List<PlayerDetailsViewModel> PlayerList { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Ties { get; set; }

        public int RankingScore
        {
            get
            {
                return Wins - Losses;
            }
        }
    }
}
