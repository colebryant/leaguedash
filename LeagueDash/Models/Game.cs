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

        [Display(Name = "Game Time")]
        [Required]
        public DateTime GameTime { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int TeamAId { get; set; }

        [Required]
        public int TeamBId { get; set; }

        public int? TeamAScore { get; set; }

        public int? TeamBScore { get; set; }
    }
}
