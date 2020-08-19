using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Items
    {
        public Items()
        {
            Inventory = new HashSet<Inventory>();
            ItemTemplates = new HashSet<ItemTemplates>();
            ItemsAmazon = new HashSet<ItemsAmazon>();
            ItemsEbay = new HashSet<ItemsEbay>();
            ItemsEtsy = new HashSet<ItemsEtsy>();
            ItemsMercado = new HashSet<ItemsMercado>();
            ItemsShopify = new HashSet<ItemsShopify>();
            Listings = new HashSet<Listings>();
            Pictures = new HashSet<Pictures>();
            ReallocateReference = new HashSet<ReallocateReference>();
        }

        public int ItemId { get; set; }
        public string ExternalItemId { get; set; }
        public bool TrackInventory { get; set; }
        public string Title { get; set; }
        public int BinId { get; set; }
        public int BusinessProfileId { get; set; }
        public int StatusId { get; set; }
        public string Notes { get; set; }
        public bool IsTaxable { get; set; }
        public byte Condition { get; set; }
        public decimal WeightMajor { get; set; }
        public decimal WeightMinor { get; set; }
        public decimal DimensionLength { get; set; }
        public decimal DimensionWidth { get; set; }
        public decimal DimensionDepth { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? LastListDate { get; set; }
        public bool IsTemplate { get; set; }
        public int? VariationSetId { get; set; }
        public bool UseVariations { get; set; }
        public bool UseSixBitInsurance { get; set; }
        public int SubStatusId { get; set; }
        public string SubmissionError { get; set; }
        public bool ReallocatePending { get; set; }
        public byte ProductIdtype { get; set; }
        public decimal Vatpercent { get; set; }
        public bool IsConsigned { get; set; }
        public int ConsignmentPlanId { get; set; }
        public int OriginTemplateId { get; set; }
        public decimal TareWeightMajor { get; set; }
        public decimal TareWeightMinor { get; set; }
        public string ProductBrand { get; set; }
        public bool? EnabledOnAmazon { get; set; }
        public bool? EnabledOnEbay { get; set; }
        public bool? EnabledOnEtsy { get; set; }
        public string CfCharger { get; set; }
        public bool Researched { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public string CfListedOn { get; set; }
        public bool? EnabledOnShopify { get; set; }

        public virtual Bins Bin { get; set; }
        public virtual BusinessProfile BusinessProfile { get; set; }
        public virtual OriginTemplates OriginTemplate { get; set; }
        public virtual VariationSets VariationSet { get; set; }
        public virtual ItemsBidstart ItemsBidstart { get; set; }
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<ItemTemplates> ItemTemplates { get; set; }
        public virtual ICollection<ItemsAmazon> ItemsAmazon { get; set; }
        public virtual ICollection<ItemsEbay> ItemsEbay { get; set; }
        public virtual ICollection<ItemsEtsy> ItemsEtsy { get; set; }
        public virtual ICollection<ItemsMercado> ItemsMercado { get; set; }
        public virtual ICollection<ItemsShopify> ItemsShopify { get; set; }
        public virtual ICollection<Listings> Listings { get; set; }
        public virtual ICollection<Pictures> Pictures { get; set; }
        public virtual ICollection<ReallocateReference> ReallocateReference { get; set; }
    }
}
