using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ItemStatuses
    {
        public int StatusId { get; set; }
        public int Family { get; set; }
        public string Name { get; set; }
        public int? GridLayoutId { get; set; }
    }
}
