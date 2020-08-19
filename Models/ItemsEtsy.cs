using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ItemsEtsy
    {
        public int ItemEtsyId { get; set; }
        public string Title { get; set; }
        public int ItemId { get; set; }
        public long ShippingTemplateId { get; set; }
        public long ShopSectionId { get; set; }
        public int AllocationPlanId { get; set; }
        public int RepricingPlanId { get; set; }
        public int TaxonomyEtsyId { get; set; }
        public bool IsCustomizable { get; set; }
        public bool NonTaxable { get; set; }
        public bool IsSupply { get; set; }
        public int State { get; set; }
        public int ProcessingMin { get; set; }
        public int ProcessingMax { get; set; }
        public int WhoMade { get; set; }
        public int WhenMade { get; set; }
        public int Recipient { get; set; }
        public int Occasion { get; set; }
        public int FeaturedRank { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public string Materials { get; set; }
        public bool AutoRenew { get; set; }
        public string Attributes { get; set; }

        public virtual AllocationPlans AllocationPlan { get; set; }
        public virtual Items Item { get; set; }
        public virtual RepricingPlans RepricingPlan { get; set; }
        public virtual ShippingTemplatesEtsy ShippingTemplate { get; set; }
        public virtual ShopSectionsEtsy ShopSection { get; set; }
        public virtual TaxonomyEtsy TaxonomyEtsy { get; set; }
    }
}
