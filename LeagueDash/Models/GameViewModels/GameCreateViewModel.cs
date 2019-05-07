using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models.GameViewModels
{
    public class GameCreateViewModel
    {
        public Game Game { get; set; }

        public List<SelectListItem> TeamsA { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> TeamsB { get; set; } = new List<SelectListItem>();

        public List<SelectListItem> TeamAOptions
        {
            get
            {
                List<SelectListItem> teamList1 = TeamsA;
                teamList1.Insert(0, new SelectListItem
                {
                    Value = null,
                    Text = "Select a Team...",
                    Selected = true
                });

                return teamList1;
            }
        }

        public List<SelectListItem> TeamBOptions
        {
            get
            {
                List<SelectListItem> teamList2 = TeamsB;
                teamList2.Insert(0, new SelectListItem
                {
                    Value = null,
                    Text = "Select a Team...",
                    Selected = true
                });

                return teamList2;
            }
        }
    }
}
