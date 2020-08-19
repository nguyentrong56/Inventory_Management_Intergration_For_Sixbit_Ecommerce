using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ShippingTemplatesEtsy
    {
        public ShippingTemplatesEtsy()
        {
            ItemsEtsy = new HashSet<ItemsEtsy>();
            ShippingTemplateUpgradesEtsy = new HashSet<ShippingTemplateUpgradesEtsy>();
        }

        public long ShippingTemplateId { get; set; }
        public string Title { get; set; }
        public int SellerAccountsEtsyId { get; set; }
        public int? MinProcessingDays { get; set; }
        public int? MaxProcessingDays { get; set; }
        public string ProcessingDaysLabel { get; set; }
        public int? OriginCountryId { get; set; }
        public int OrdinalId { get; set; }

        public virtual SellerAccountsEtsy SellerAccountsEtsy { get; set; }
        public virtual ICollection<ItemsEtsy> ItemsEtsy { get; set; }
        public virtual ICollection<ShippingTemplateUpgradesEtsy> ShippingTemplateUpgradesEtsy { get; set; }
    }
}
