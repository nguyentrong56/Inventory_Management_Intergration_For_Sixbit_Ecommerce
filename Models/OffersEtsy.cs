using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class OffersEtsy
    {
        public int OfferEtsyId { get; set; }
        public int InventoryId { get; set; }
        public string SiteOfferId { get; set; }
        public byte SiteId { get; set; }

        public virtual Inventory Inventory { get; set; }
    }
}
