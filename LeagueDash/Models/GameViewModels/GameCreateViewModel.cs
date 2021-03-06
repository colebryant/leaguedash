﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueDash.Models.GameViewModels
{
    public class GameCreateViewModel
    {
        public Game Game { get; set; }

        public IEnumerable<SelectListItem> TeamAOptions { get; set; }

        public IEnumerable<SelectListItem> TeamBOptions { get; set; }
    }
}
