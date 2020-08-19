using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class SellerAccountsShopify
    {
        public SellerAccountsShopify()
        {
            BusinessProfile = new HashSet<BusinessProfile>();
            CollectionsShopify = new HashSet<CollectionsShopify>();
            LocationsShopify = new HashSet<LocationsShopify>();
        }

        public int SellerAccountsShopifyId { get; set; }
        public string ShopName { get; set; }
        public string Token { get; set; }
        public string Scopes { get; set; }
        public string SellerRefreshDetails { get; set; }
        public int ShopCurrency { get; set; }
        public bool? Enabled { get; set; }

        public virtual ICollection<BusinessProfile> BusinessProfile { get; set; }
        public virtual ICollection<CollectionsShopify> CollectionsShopify { get; set; }
        public virtual ICollection<LocationsShopify> LocationsShopify { get; set; }
    }
}
