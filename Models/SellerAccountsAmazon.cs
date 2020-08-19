using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class SellerAccountsAmazon
    {
        public SellerAccountsAmazon()
        {
            BusinessProfile = new HashSet<BusinessProfile>();
        }

        public int SellerAccountsAmazonId { get; set; }
        public string SellerId { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string SellerRefreshDetails { get; set; }
        public bool? UseOutOfStockControl { get; set; }
        public bool? Enabled { get; set; }

        public virtual ICollection<BusinessProfile> BusinessProfile { get; set; }
    }
}
