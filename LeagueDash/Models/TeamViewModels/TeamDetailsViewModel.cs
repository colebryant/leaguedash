﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models.TeamViewModels
{
    public class TeamDetailsViewModel
    {
        public Team Team { get; set; }

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
    }
}