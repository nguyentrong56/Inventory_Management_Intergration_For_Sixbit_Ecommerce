using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Inventory
    {
        public Inventory()
        {
            ChangeRequests = new HashSet<ChangeRequests>();
            InventoryFeeds = new HashSet<InventoryFeeds>();
            OffersEtsy = new HashSet<OffersEtsy>();
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetails>();
            Purchases = new HashSet<Purchases>();
        }

        public int InventoryId { get; set; }
        public int ItemId { get; set; }
        public int? QtyToList { get; set; }
        public string Sku { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal ReservePrice { get; set; }
        public decimal Msrp { get; set; }
        public decimal FixedPrice { get; set; }
        public string Variation1 { get; set; }
        public string Variation2 { get; set; }
        public string Variation3 { get; set; }
        public string Variation4 { get; set; }
        public string Variation5 { get; set; }
        public decimal BuyItNowPrice { get; set; }
        public bool? VariationInUse { get; set; }
        public int VariationScarcityLevel { get; set; }
        public string StorageLocation { get; set; }
        public byte RestockAt { get; set; }
        public string ProductId { get; set; }
        public byte PricingTreatment { get; set; }
        public byte MinimumAdvertisedPriceExposure { get; set; }
        public byte FulfillmentLatency { get; set; }
        public DateTime? RestockDate { get; set; }
        public decimal FixedPriceAmazon { get; set; }
        public decimal MinimumAdvertisedPrice { get; set; }
        public DateTime? SaleStartDateAmazon { get; set; }
        public DateTime? SaleEndDateAmazon { get; set; }
        public decimal? MinimumSellerAllowedPrice { get; set; }
        public decimal? MaximumSellerAllowedPrice { get; set; }
        public decimal? SalePriceAmazon { get; set; }
        public string Asin { get; set; }
        public decimal FixedPriceEtsy { get; set; }
        public string Features { get; set; }
        public byte PrimaryFulfillmentSource { get; set; }
        public byte SecondaryFulfillmentSource { get; set; }
        public bool ForceUpdate { get; set; }
        public int QtyToListEtsy { get; set; }
        public int RestockTo { get; set; }
        public int? PreferredSupplierId { get; set; }
        public DateTime? FbareconciliationDate { get; set; }
        public long ProductIdetsy { get; set; }
        public string FulfillmentChannelSku { get; set; }
        public string Title { get; set; }
        public string CatalogPhotoEbay { get; set; }
        public string Epid { get; set; }

        public int? ExternalQuantity { get; set; }
        public int? AmazonQuantity { get; set; }
        public int? QtyUncommitted { get; set; }
        public long VariantIdshopify { get; set; }
        public long InventoryItemIdshopify { get; set; }
        public int InventoryPolicyShopify { get; set; }
        public decimal FixedPriceShopify { get; set; }
        public bool? TaxableShopify { get; set; }
        public string InventoryManagementShopify { get; set; }

        public virtual Items Item { get; set; }
        public virtual ICollection<ChangeRequests> ChangeRequests { get; set; }
        public virtual ICollection<InventoryFeeds> InventoryFeeds { get; set; }
        public virtual ICollection<OffersEtsy> OffersEtsy { get; set; }
        public virtual ICollection<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }
        public virtual ICollection<Purchases> Purchases { get; set; }
    }
}
