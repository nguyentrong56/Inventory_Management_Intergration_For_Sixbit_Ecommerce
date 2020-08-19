using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Sales
    {
        public Sales()
        {
            SalesPurchases = new HashSet<SalesPurchases>();
        }

        public int SaleId { get; set; }
        public int ShipmentId { get; set; }
        public string ECommerceId { get; set; }
        public string TransactionId { get; set; }
        public string Title { get; set; }
        public int ListingType { get; set; }
        public decimal SalePrice { get; set; }
        public int QtySold { get; set; }
        public decimal SalesTax { get; set; }
        public int OriginalShippingServiceId { get; set; }
        public decimal OriginalChargedShippingCost { get; set; }
        public decimal Fvf { get; set; }
        public DateTime? SaleDate { get; set; }
        public bool InDispute { get; set; }
        public string DisputeId { get; set; }
        public DateTime? FvfrefundRequestedDate { get; set; }
        public decimal WeightMajor { get; set; }
        public decimal WeightMinor { get; set; }
        public bool FeedbackReceived { get; set; }
        public bool FeedbackLeft { get; set; }
        public string Notes { get; set; }
        public string CustomFields { get; set; }
        public decimal? ExtendedPrice { get; set; }
        public string FeedbackMessageReceived { get; set; }
        public string FeedbackResponseSent { get; set; }
        public string FeedbackMessageSent { get; set; }
        public int FeedbackTypeReceived { get; set; }
        public int FeedbackTypeSent { get; set; }
        public bool IsConsigned { get; set; }
        public bool IsConsignorPaid { get; set; }
        public int ConsignmentPlanId { get; set; }
        public DateTime? ConsignorPaidDate { get; set; }
        public DateTime? ConsignorNotifiedDate { get; set; }
        public bool IsConsignorNotificationSent { get; set; }
        public decimal CommissionIn { get; set; }
        public decimal TotalConsignorCharges { get; set; }
        public decimal ConsignorListingFee { get; set; }
        public decimal PaymentProcessingFee { get; set; }
        public int CurrencyCode { get; set; }
        public decimal RawSalePrice { get; set; }
        public decimal ConversionRate { get; set; }
        public decimal Vatamount { get; set; }
        public bool GuaranteedDelivery { get; set; }
        public decimal ListingFee { get; set; }
        public decimal AdFee { get; set; }
        public decimal SiteSalesTaxCollectedAmount { get; set; }

        public virtual Shipments Shipment { get; set; }
        public virtual ICollection<SalesPurchases> SalesPurchases { get; set; }
    }
}
