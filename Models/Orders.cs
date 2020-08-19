using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrdersFeeds = new HashSet<OrdersFeeds>();
            Shipments = new HashSet<Shipments>();
        }

        public int OrderId { get; set; }
        public int BuyerId { get; set; }
        public int StatusId { get; set; }
        public bool IsInvoiced { get; set; }
        public DateTime? InvoicedDate { get; set; }
        public decimal TotalPaidAmount { get; set; }
        public decimal TotalDueAmount { get; set; }
        public int BillingAddressId { get; set; }
        public decimal AdjustmentFee { get; set; }
        public string AdjustmentFeeReason { get; set; }
        public decimal AdjustmentCost { get; set; }
        public string AdjustmentCostReason { get; set; }
        public int? Ccid { get; set; }
        public int PaymentTypeId { get; set; }
        public DateTime? PaymentReceivedDate { get; set; }
        public DateTime? PaymentClearedDate { get; set; }
        public bool BuyerSelectedShipping { get; set; }
        public bool CheckoutCompleted { get; set; }
        public int BusinessProfileId { get; set; }
        public byte SiteId { get; set; }
        public short SellerCurrency { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? FulfilledDate { get; set; }
        public string CombinedOrderId { get; set; }
        public decimal SalesTax { get; set; }
        public string Notes { get; set; }
        public bool IsPaymentAckSent { get; set; }
        public bool IsFeedbackReminderSent { get; set; }
        public DateTime? PaymentAckSentDate { get; set; }
        public DateTime? FeedbackReminderSentDate { get; set; }
        public decimal PaymentProcessingFee { get; set; }
        public int SubStatusId { get; set; }
        public string ExternalOrderId { get; set; }
        public string ExternalTransactionDetails { get; set; }
        public string SubmissionError { get; set; }
        public bool IsLocal { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public DateTime? LatestShipDate { get; set; }
        public DateTime? LatestDeliveryDate { get; set; }
        public DateTime? EarliestShipDate { get; set; }
        public DateTime? EarliestDeliveryDate { get; set; }
        public int FeeStatus { get; set; }
        public decimal Vatamount { get; set; }
        public bool GuaranteedDelivery { get; set; }
        public bool IsGift { get; set; }
        public bool NeedsGiftWrap { get; set; }
        public string GiftMessage { get; set; }
        public decimal GiftWrapPrice { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool SiteSalesTaxCollected { get; set; }
        public string ExternalTransactionId { get; set; }
        public string SiteOrderId { get; set; }
        public decimal? RemainingDueAmount { get; set; }

        public virtual BusinessProfile BusinessProfile { get; set; }
        public virtual CreditCards Cc { get; set; }
        public virtual OrderStatuses Status { get; set; }
        public virtual ICollection<OrdersFeeds> OrdersFeeds { get; set; }
        public virtual ICollection<Shipments> Shipments { get; set; }
    }
}
