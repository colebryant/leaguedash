﻿//This file contains the model representing a user's Role (Player/Captain/Commissioner)

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Display(Name = "Role")]
        public string Name { get; set; }
    }
}
