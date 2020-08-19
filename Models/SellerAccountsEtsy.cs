using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class SellerAccountsEtsy
    {
        public SellerAccountsEtsy()
        {
            BillChargesEtsy = new HashSet<BillChargesEtsy>();
            BusinessProfile = new HashSet<BusinessProfile>();
            ShippingTemplatesEtsy = new HashSet<ShippingTemplatesEtsy>();
            ShopSectionsEtsy = new HashSet<ShopSectionsEtsy>();
        }

        public int SellerAccountsEtsyId { get; set; }
        public string Token { get; set; }
        public string TokenSecret { get; set; }
        public long UserId { get; set; }
        public string ShopName { get; set; }
        public int ShopId { get; set; }
        public int RateLimitRemaining { get; set; }
        public bool AcceptsCustomRequests { get; set; }
        public string SellerRefreshDetails { get; set; }
        public string Scopes { get; set; }
        public bool? Enabled { get; set; }

        public virtual ICollection<BillChargesEtsy> BillChargesEtsy { get; set; }
        public virtual ICollection<BusinessProfile> BusinessProfile { get; set; }
        public virtual ICollection<ShippingTemplatesEtsy> ShippingTemplatesEtsy { get; set; }
        public virtual ICollection<ShopSectionsEtsy> ShopSectionsEtsy { get; set; }
    }
}
