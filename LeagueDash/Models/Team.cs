//This file contains the model representing the Team resource in the database

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models
{
    public class Team
    {
        [Display(Name = "Team ID")]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        [Required]
        public string CaptainId { get; set; }
    }
}
