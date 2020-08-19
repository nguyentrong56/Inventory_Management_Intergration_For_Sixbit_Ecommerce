using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ShippingServices
    {
        public int ShippingServiceId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsInternational { get; set; }
        public bool IsCheckout { get; set; }
        public int SiteId { get; set; }
        public int OrdinalId { get; set; }
        public string PackageSizeAllowed { get; set; }
        public bool HasSurcharge { get; set; }
        public int EBayServiceId { get; set; }
        public string GroupName { get; set; }
        public int GroupOrdinalId { get; set; }
        public bool IsMappable { get; set; }
        public bool IsFlat { get; set; }
        public bool IsCalculated { get; set; }
        public int ShippingTimeMin { get; set; }
        public int ShippingTimeMax { get; set; }
    }
}
