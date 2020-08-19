using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ItemsEbay
    {
        public int ItemEbayId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public int ThemeId { get; set; }
        public int DescriptionWrapperId { get; set; }
        public int? DescriptionId { get; set; }
        public int ListingUpgradeId { get; set; }
        public int ShippingTemplateId { get; set; }
        public int PaymentTemplateId { get; set; }
        public short LotSize { get; set; }
        public bool Private { get; set; }
        public int Category1 { get; set; }
        public int Category2 { get; set; }
        public long StoreCategory1 { get; set; }
        public long StoreCategory2 { get; set; }
        public string ItemSpecifics { get; set; }
        public string StockPhotoUrl { get; set; }
        public bool UseStockTitle { get; set; }
        public bool UseStockPhoto { get; set; }
        public bool UseStockPhotoAsGallery { get; set; }
        public bool UsePreWrittenSummary { get; set; }
        public string CatalogSummary { get; set; }
        public bool BestOffer { get; set; }
        public bool AutoDeclineBo { get; set; }
        public decimal AutoDeclineBovalue { get; set; }
        public bool AutoAcceptBo { get; set; }
        public decimal AutoAcceptBovalue { get; set; }
        public int ItemId { get; set; }
        public bool CatalogItem { get; set; }
        public byte CounterId { get; set; }
        public bool PictureResize { get; set; }
        public short PictureSize { get; set; }
        public bool SelfHostPictures { get; set; }
        public bool PicturePack { get; set; }
        public string ProductReferenceId { get; set; }
        public int AllocationPlanId { get; set; }
        public int RepricingPlanId { get; set; }
        public int? CompatibilitySetId { get; set; }
        public bool CompatibilityCatalogItem { get; set; }
        public bool UseCompatibilityStockTitle { get; set; }
        public bool UseCompatibilityStockPhoto { get; set; }
        public bool UseCompatibilityStockPhotoAsGallery { get; set; }
        public string ConditionDescription { get; set; }
        public decimal AutoDeclineBopercent { get; set; }
        public decimal AutoAcceptBopercent { get; set; }
        public byte AutoDeclineBovalueType { get; set; }
        public byte AutoAcceptBovalueType { get; set; }
        public int CharityId { get; set; }
        public decimal CharityPercent { get; set; }
        public long PaymentPolicyId { get; set; }
        public long ReturnPolicyId { get; set; }
        public long ShippingPolicyId { get; set; }
        public bool UseShippingCostOverride { get; set; }
        public string ShippingServiceCostOverrideList { get; set; }
        public int ConditionId { get; set; }
        public short ShippingPackage { get; set; }
        public bool ShippingIrregular { get; set; }
        public string Aspects { get; set; }
        public string ReasonForChangeRequest { get; set; }
        public bool BestOfferAuction { get; set; }

        public virtual AllocationPlans AllocationPlan { get; set; }
        public virtual CategoriesEbay Category1Navigation { get; set; }
        public virtual CategoriesEbay Category2Navigation { get; set; }
        public virtual CompatibilitySets CompatibilitySet { get; set; }
        public virtual Descriptions Description { get; set; }
        public virtual DescriptionWrappers DescriptionWrapper { get; set; }
        public virtual Items Item { get; set; }
        public virtual ListingUpgradeTemplates ListingUpgrade { get; set; }
        public virtual PaymentTemplates PaymentTemplate { get; set; }
        public virtual RepricingPlans RepricingPlan { get; set; }
        public virtual ShippingTemplates ShippingTemplate { get; set; }
    }
}
