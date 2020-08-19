using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ItemsShopify
    {
        public ItemsShopify()
        {
            CollectsShopify = new HashSet<CollectsShopify>();
        }

        public int ItemShopifyId { get; set; }
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Seotitle { get; set; }
        public string Seodescription { get; set; }
        public string Handle { get; set; }
        public string ProductType { get; set; }
        public string Tags { get; set; }
        public string Vendor { get; set; }
        public int AllocationPlanId { get; set; }
        public long ProductIdshopify { get; set; }
        public int? DescriptionWrapperId { get; set; }

        public virtual AllocationPlans AllocationPlan { get; set; }
        public virtual DescriptionWrappers DescriptionWrapper { get; set; }
        public virtual Items Item { get; set; }
        public virtual ICollection<CollectsShopify> CollectsShopify { get; set; }
    }
}
