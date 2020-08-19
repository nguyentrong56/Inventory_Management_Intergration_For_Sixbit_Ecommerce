using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class CollectsShopify
    {
        public int CollectIndex { get; set; }
        public long CollectId { get; set; }
        public long CollectionId { get; set; }
        public int ItemShopifyId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Featured { get; set; }
        public int? Position { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual CollectionsShopify Collection { get; set; }
        public virtual ItemsShopify ItemShopify { get; set; }
    }
}
