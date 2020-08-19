using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ListingsBidstart
    {
        public int ListingBidStartId { get; set; }
        public int Category1 { get; set; }
        public int Category2 { get; set; }
        public bool BestOffer { get; set; }
        public bool SelfHostPictures { get; set; }
        public decimal SpotGoldPrice { get; set; }
        public decimal SpotGoldPercent { get; set; }
        public int ListingIdlink { get; set; }

        public virtual Listings ListingIdlinkNavigation { get; set; }
    }
}
