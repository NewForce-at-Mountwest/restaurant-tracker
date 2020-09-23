using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTracker.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name="Restaurant Name")]
        public string Name { get; set; }

        public List<Waiter> Waiters { get; set; } = new List<Waiter>();

        public List<Table> Tables { get; set; } = new List<Table>();

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }
    }
}
