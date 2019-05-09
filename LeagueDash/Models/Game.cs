//This file contains the model representing the Game resource in the database

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models
{
    public class Game
    {
        [Display(Name = "Game ID")]
        public int Id { get; set; }

        [Display(Name = "Date and Time")]
        [Required]
        public DateTime GameTime { get; set; }

        [Required]
        public string Location { get; set; }

        [Display(Name = "Team A")]
        [Required]
        public int TeamAId { get; set; }

        [Display(Name = "Team B")]
        [Required]
        public int TeamBId { get; set; }

        [Display(Name = "Team A Score")]
        public int? TeamAScore { get; set; }

        [Display(Name = "Team B Score")]
        public int? TeamBScore { get; set; }
    }
}
