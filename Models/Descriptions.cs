using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Descriptions
    {
        public Descriptions()
        {
            ItemsBidstart = new HashSet<ItemsBidstart>();
            ItemsEbay = new HashSet<ItemsEbay>();
            ItemsMercado = new HashSet<ItemsMercado>();
            Listings = new HashSet<Listings>();
        }

        public int DescriptionId { get; set; }
        public string Description { get; set; }
        public string Css { get; set; }
        public bool IsRawMode { get; set; }
        public string ExternalDescriptionId { get; set; }

        public virtual ICollection<ItemsBidstart> ItemsBidstart { get; set; }
        public virtual ICollection<ItemsEbay> ItemsEbay { get; set; }
        public virtual ICollection<ItemsMercado> ItemsMercado { get; set; }
        public virtual ICollection<Listings> Listings { get; set; }
    }
}
