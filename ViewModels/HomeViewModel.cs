﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;

namespace WebApplication2.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Item> favItems { get; set; }
    }
}
