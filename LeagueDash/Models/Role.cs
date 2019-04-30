//This file contains the model representing a user's Role (Player/Captain/Commissioner)

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models
{
    public class Role
    {
        [Display(Name = "Role ID")]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
