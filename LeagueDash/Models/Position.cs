//This file contains the model representing a user's preferred Position (Goalkeeper/Defender/Midfielder/Forward/No Preference)

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models
{
    public class Position
    {
        public int Id { get; set; }

        [Display(Name = "Preferred Position")]
        public string Name { get; set; }
    }
}
