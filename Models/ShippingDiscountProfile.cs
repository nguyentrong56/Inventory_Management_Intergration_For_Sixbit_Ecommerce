using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ShippingDiscountProfile
    {
        public string ShippingDiscountProfileId { get; set; }
        public string SellerAccounteBay { get; set; }
        public short ShippingType { get; set; }
        public string Name { get; set; }
        public short SiteId { get; set; }
    }
}
