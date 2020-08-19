using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ShippingTemplateUpgradesEtsy
    {
        public long ShippingTemplateUpgradeId { get; set; }
        public long ShippingTemplateId { get; set; }
        public string Title { get; set; }
        public decimal? Price { get; set; }
        public decimal? SecondaryPrice { get; set; }
        public string CurrencyCode { get; set; }
        public byte? Type { get; set; }
        public int? OrdinalId { get; set; }
        public int? Language { get; set; }

        public virtual ShippingTemplatesEtsy ShippingTemplate { get; set; }
    }
}
