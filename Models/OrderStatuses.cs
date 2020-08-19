using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class OrderStatuses
    {
        public OrderStatuses()
        {
            Orders = new HashSet<Orders>();
        }

        public int StatusId { get; set; }
        public int Family { get; set; }
        public string Name { get; set; }
        public int? GridLayoutId { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
