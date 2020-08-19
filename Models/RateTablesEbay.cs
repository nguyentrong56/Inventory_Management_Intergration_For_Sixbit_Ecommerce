using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class RateTablesEbay
    {
        public long RateTableEbayId { get; set; }
        public string SellerAccount { get; set; }
        public string Name { get; set; }
        public byte Locality { get; set; }
        public string CountryCode { get; set; }
    }
}
