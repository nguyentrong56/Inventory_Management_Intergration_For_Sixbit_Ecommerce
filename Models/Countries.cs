using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Countries
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public bool IsInsuranceExcluded { get; set; }
        public int? AddressFormatId { get; set; }
        public int EtsyCountryId { get; set; }
    }
}
