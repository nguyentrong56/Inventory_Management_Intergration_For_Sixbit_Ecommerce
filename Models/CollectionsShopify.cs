using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class CollectionsShopify
    {
        public CollectionsShopify()
        {
            CollectsShopify = new HashSet<CollectsShopify>();
        }

        public long CollectionId { get; set; }
        public int Type { get; set; }
        public string Title { get; set; }
        public string BodyHtml { get; set; }
        public string Handle { get; set; }
        public string ImageSrc { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string PublishedScope { get; set; }
        public int? SortOrder { get; set; }
        public string TemplateSuffix { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Rules { get; set; }
        public bool? Disjunctive { get; set; }
        public int SellerAccountsShopifyId { get; set; }

        public virtual SellerAccountsShopify SellerAccountsShopify { get; set; }
        public virtual ICollection<CollectsShopify> CollectsShopify { get; set; }
    }
}
