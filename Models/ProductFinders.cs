using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ProductFinders
    {
        public int CatNumSiteId { get; set; }
        public bool BuySide { get; set; }
        public int ProductFinderId { get; set; }
        public int SiteId { get; set; }
    }
}
