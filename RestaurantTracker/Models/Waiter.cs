using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantTracker.Models
{
    public class Waiter
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Table> Tables { get; set; } = new List<Table>();

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }
    }
}
