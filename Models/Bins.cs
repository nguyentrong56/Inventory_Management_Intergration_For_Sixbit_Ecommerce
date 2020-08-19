using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Bins
    {
        public Bins()
        {
            Items = new HashSet<Items>();
        }

        public int BinId { get; set; }
        public string BinName { get; set; }
        public int? ParentId { get; set; }
        public int? OrdinalId { get; set; }

        public virtual ICollection<Items> Items { get; set; }
    }
}
