using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class SalesTax
    {
        public int SalesTaxId { get; set; }
        public int BusinessProfileId { get; set; }
        public string AuthorityType { get; set; }
        public string Authority { get; set; }
        public decimal? TaxPercent { get; set; }
        public bool IncludeOnShipping { get; set; }
    }
}
