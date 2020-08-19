using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class LocationsShopify
    {
        public LocationsShopify()
        {
            Purchases = new HashSet<Purchases>();
        }

        public long Id { get; set; }
        public int SellerAccountsShopifyId { get; set; }
        public bool Active { get; set; }
        public bool Legacy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Province { get; set; }
        public string ProvinceCode { get; set; }
        public string Zip { get; set; }

        public virtual SellerAccountsShopify SellerAccountsShopify { get; set; }
        public virtual ICollection<Purchases> Purchases { get; set; }
    }
}
