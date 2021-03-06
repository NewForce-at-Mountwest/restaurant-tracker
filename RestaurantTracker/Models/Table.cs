﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTracker.Models
{
    public class Table
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int WaiterId { get; set; }

        public Waiter Waiter { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public Restaurant Restaurant { get; set; }

        [Display(Name="Restaurant")]
        public int RestaurantId { get; set; }
    }
}
