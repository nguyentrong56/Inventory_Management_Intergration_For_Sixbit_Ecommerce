using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ItemsBidstart
    {
        public int ItemBidstartId { get; set; }
        public string Title { get; set; }
        public int DescriptionWrapperId { get; set; }
        public int? DescriptionId { get; set; }
        public int ListingUpgradeId { get; set; }
        public int ShippingTemplateId { get; set; }
        public int PaymentTemplateId { get; set; }
        public int Category1 { get; set; }
        public int Category2 { get; set; }
        public bool BestOffer { get; set; }
        public int ItemId { get; set; }
        public bool SelfHostPictures { get; set; }
        public decimal SpotGoldPrice { get; set; }
        public decimal SpotGoldPercent { get; set; }
        public int AllocationPlanId { get; set; }
        public int RepricingPlanId { get; set; }

        public virtual AllocationPlans AllocationPlan { get; set; }
        public virtual CategoriesBidStart Category1Navigation { get; set; }
        public virtual CategoriesBidStart Category2Navigation { get; set; }
        public virtual Descriptions Description { get; set; }
        public virtual DescriptionWrappers DescriptionWrapper { get; set; }
        public virtual Items Item { get; set; }
        public virtual ListingUpgradeTemplates ListingUpgrade { get; set; }
        public virtual PaymentTemplates PaymentTemplate { get; set; }
        public virtual RepricingPlans RepricingPlan { get; set; }
        public virtual ShippingTemplates ShippingTemplate { get; set; }
    }
}
