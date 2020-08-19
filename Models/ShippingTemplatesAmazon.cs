using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ShippingTemplatesAmazon
    {
        public ShippingTemplatesAmazon()
        {
            ItemsAmazon = new HashSet<ItemsAmazon>();
        }

        public int ShippingTemplateId { get; set; }
        public string Name { get; set; }
        public int OrdinalId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastUsed { get; set; }

        public virtual ICollection<ItemsAmazon> ItemsAmazon { get; set; }
    }
}
