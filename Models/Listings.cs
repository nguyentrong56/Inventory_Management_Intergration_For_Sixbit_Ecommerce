using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Listings
    {
        public Listings()
        {
            ListingsBidstart = new HashSet<ListingsBidstart>();
            ListingsEbay = new HashSet<ListingsEbay>();
            ListingsMercado = new HashSet<ListingsMercado>();
            ReallocateReference = new HashSet<ReallocateReference>();
        }

        public int ListingId { get; set; }
        public byte SiteId { get; set; }
        public short SellerCurrency { get; set; }
        public int ItemId { get; set; }
        public int StatusId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte ListingType { get; set; }
        public short Duration { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public string CurrentBidderEmail { get; set; }
        public string CurrentBidderUserid { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime? LastBidDate { get; set; }
        public int NumberSold { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal FixedPrice { get; set; }
        public decimal ReservePrice { get; set; }
        public decimal BuyItNowPrice { get; set; }
        public decimal ListingFee { get; set; }
        public string ListingFeeDetails { get; set; }
        public int SubmittedBy { get; set; }
        public int QtyToList { get; set; }
        public int OriginalQtyToList { get; set; }
        public short LotSize { get; set; }
        public bool Private { get; set; }
        public string Notes { get; set; }
        public string Uuid { get; set; }
        public string LastSaleTransactionId { get; set; }
        public bool IsTaxable { get; set; }
        public short BidCount { get; set; }
        public int HitCount { get; set; }
        public short WatchCount { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? LastRevisedDate { get; set; }
        public string SubmissionError { get; set; }
        public int BusinessProfileId { get; set; }
        public int SubStatusId { get; set; }
        public string ECommerceId { get; set; }
        public int? DescriptionId { get; set; }
        public int ListingUpgradeId { get; set; }
        public int ShippingTemplateId { get; set; }
        public int PaymentTemplateId { get; set; }
        public int DescriptionWrapperId { get; set; }
        public string Title { get; set; }
        public string OriginaleCommerceId { get; set; }
        public string RevisionError { get; set; }
        public string SiteLink { get; set; }
        public decimal Vatpercent { get; set; }
        public byte ListingLevel { get; set; }
        public int BuyerQuestionCount { get; set; }
        public DateTime? OldestQuestionDate { get; set; }
        public bool IsConsignorListingFeePaid { get; set; }
        public bool RevisionPending { get; set; }
        public bool ForceNewListing { get; set; }
        public string SbmetaData { get; set; }
        public int? ListingSource { get; set; }
        public bool OutOfStock { get; set; }
        public bool DeletionPending { get; set; }
        public int? QtyRemaining { get; set; }
        public string ScooriginaleCommerceId { get; set; }
        public long OfferId { get; set; }
        public decimal ListingFeePaid { get; set; }
        public int ListingViolationType { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? AutoEndDate { get; set; }
        public int CustomDuration { get; set; }
        public int ListingViolationState { get; set; }

        public virtual BusinessProfile BusinessProfile { get; set; }
        public virtual Descriptions Description { get; set; }
        public virtual DescriptionWrappers DescriptionWrapper { get; set; }
        public virtual Items Item { get; set; }
        public virtual ListingUpgradeTemplates ListingUpgrade { get; set; }
        public virtual PaymentTemplates PaymentTemplate { get; set; }
        public virtual ShippingTemplates ShippingTemplate { get; set; }
        public virtual ICollection<ListingsBidstart> ListingsBidstart { get; set; }
        public virtual ICollection<ListingsEbay> ListingsEbay { get; set; }
        public virtual ICollection<ListingsMercado> ListingsMercado { get; set; }
        public virtual ICollection<ReallocateReference> ReallocateReference { get; set; }
    }
}
