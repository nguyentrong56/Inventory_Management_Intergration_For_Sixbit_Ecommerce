using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ItemsAmazon
    {
        public int ItemsAmazonId { get; set; }
        public int ItemId { get; set; }
        public int AllocationPlanId { get; set; }
        public int RepricingPlanId { get; set; }
        public string CatalogSummary { get; set; }
        public byte Condition { get; set; }
        public string ConditionDescription { get; set; }
        public int TaxCode { get; set; }
        public int? ShippingTemplateId { get; set; }
        public int CategoryId { get; set; }
        public bool SendPicturesWithRevision { get; set; }
        public string ParentAsin { get; set; }
        public string ParentSku { get; set; }
        public bool SendRelationships { get; set; }

        public virtual AllocationPlans AllocationPlan { get; set; }
        public virtual CategoriesAmazon Category { get; set; }
        public virtual Items Item { get; set; }
        public virtual RepricingPlans RepricingPlan { get; set; }
        public virtual ShippingTemplatesAmazon ShippingTemplate { get; set; }
    }
}
