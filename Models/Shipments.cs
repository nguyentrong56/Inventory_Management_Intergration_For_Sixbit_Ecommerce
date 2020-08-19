using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Shipments
    {
        public Shipments()
        {
            Sales = new HashSet<Sales>();
        }

        public int ShipmentId { get; set; }
        public int OrderId { get; set; }
        public int ShippingAddressId { get; set; }
        public int ShippingServiceId { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal HandlingFee { get; set; }
        public decimal ChargedShippingCost { get; set; }
        public decimal ActualShippingCost { get; set; }
        public decimal ActualInsuranceCost { get; set; }
        public string TrackingNumber { get; set; }
        public decimal WeightMajor { get; set; }
        public decimal WeightMinor { get; set; }
        public decimal DimensionLength { get; set; }
        public decimal DimensionWidth { get; set; }
        public decimal DimensionDepth { get; set; }
        public byte InsuranceType { get; set; }
        public decimal InsuredValue { get; set; }
        public bool IsPackingListPrinted { get; set; }
        public bool IsPostagePrinted { get; set; }
        public DateTime? InsuredDate { get; set; }
        public string InsuranceId { get; set; }
        public string BillableItemId { get; set; }
        public string Notes { get; set; }
        public bool IsMissing { get; set; }
        public bool IsShipped { get; set; }
        public bool IsShippedNotificationSent { get; set; }
        public int? SelectedOrdinalId { get; set; }
        public DateTime? ShippedNotificationSentDate { get; set; }
        public bool NotifySite { get; set; }
        public bool IsDropShipperNotified { get; set; }
        public DateTime? DropShipperNotifiedDate { get; set; }
        public string ExternalShipmentId { get; set; }
        public string ExternalManualService { get; set; }
        public string ExternalManualServiceId { get; set; }
        public int ExternalShippingType { get; set; }
        public int OriginTemplateId { get; set; }
        public bool IsScanFormPrinted { get; set; }
        public bool IsUspspickupRequested { get; set; }
        public int IntegratedCarrierId { get; set; }
        public int? ScanFormManifestId { get; set; }
        public int? UspspickupManifestId { get; set; }
        public byte FulfillmentSource { get; set; }

        public virtual Orders Order { get; set; }
        public virtual OriginTemplates OriginTemplate { get; set; }
        public virtual Manifests ScanFormManifest { get; set; }
        public virtual Addresses ShippingAddress { get; set; }
        public virtual Manifests UspspickupManifest { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
