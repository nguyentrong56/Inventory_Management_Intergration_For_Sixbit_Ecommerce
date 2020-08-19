using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class DescriptionWrappers
    {
        public DescriptionWrappers()
        {
            ItemsBidstart = new HashSet<ItemsBidstart>();
            ItemsEbay = new HashSet<ItemsEbay>();
            ItemsMercado = new HashSet<ItemsMercado>();
            ItemsShopify = new HashSet<ItemsShopify>();
            Listings = new HashSet<Listings>();
        }

        public int DescriptionWrapperId { get; set; }
        public string Name { get; set; }
        public string HtmlContent { get; set; }
        public int OrdinalId { get; set; }
        public string Css { get; set; }
        public bool IsRawMode { get; set; }
        public int LayoutId { get; set; }
        public int SiteId { get; set; }
        public int SubSiteId { get; set; }

        public virtual ICollection<ItemsBidstart> ItemsBidstart { get; set; }
        public virtual ICollection<ItemsEbay> ItemsEbay { get; set; }
        public virtual ICollection<ItemsMercado> ItemsMercado { get; set; }
        public virtual ICollection<ItemsShopify> ItemsShopify { get; set; }
        public virtual ICollection<Listings> Listings { get; set; }
    }
}
