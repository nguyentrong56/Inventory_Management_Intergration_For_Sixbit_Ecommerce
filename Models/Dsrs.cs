using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Dsrs
    {
        public DateTime RefreshDate { get; set; }
        public string SellerRatingSummaryArray { get; set; }
        public int Dsrid { get; set; }
        public int SellerAccountseBayId { get; set; }

        public virtual SellerAccountseBay SellerAccountseBay { get; set; }
    }
}
