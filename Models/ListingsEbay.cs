using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ListingsEbay
    {
        public int ListingEbayId { get; set; }
        public string SubTitle { get; set; }
        public int ThemeId { get; set; }
        public int Category1 { get; set; }
        public int Category2 { get; set; }
        public long StoreCategory1 { get; set; }
        public long StoreCategory2 { get; set; }
        public string ItemSpecifics { get; set; }
        public bool UseStockTitle { get; set; }
        public bool UseStockPhoto { get; set; }
        public bool UseStockPhotoAsGallery { get; set; }
        public bool UsePreWrittenSummary { get; set; }
        public string StockPhotoUrl { get; set; }
        public int MissingSalesCount { get; set; }
        public bool BestOffer { get; set; }
        public bool AutoDeclineBo { get; set; }
        public decimal AutoDeclineBovalue { get; set; }
        public bool AutoAcceptBo { get; set; }
        public decimal AutoAcceptBovalue { get; set; }
        public byte CounterId { get; set; }
        public bool PictureResize { get; set; }
        public short PictureSize { get; set; }
        public string CatalogSummary { get; set; }
        public bool PicturePack { get; set; }
        public bool CatalogItem { get; set; }
        public int EndReasonCode { get; set; }
        public int ListingIdlink { get; set; }
        public int? CompatibilitySetId { get; set; }
        public bool CompatibilityCatalogItem { get; set; }
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
        public string ListingRecommendations { get; set; }
        public long? AdId { get; set; }

        public virtual AdsEbay Ad { get; set; }
        public virtual CompatibilitySets CompatibilitySet { get; set; }
        public virtual Listings ListingIdlinkNavigation { get; set; }
    }
}
