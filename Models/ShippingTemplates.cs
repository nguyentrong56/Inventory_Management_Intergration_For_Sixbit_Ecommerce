using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ShippingTemplates
    {
        public ShippingTemplates()
        {
            ItemsBidstart = new HashSet<ItemsBidstart>();
            ItemsEbay = new HashSet<ItemsEbay>();
            ItemsMercado = new HashSet<ItemsMercado>();
            Listings = new HashSet<Listings>();
        }

        public int ShippingTemplateId { get; set; }
        public string Name { get; set; }
        public short ShippingType { get; set; }
        public short PackageSize { get; set; }
        public bool OddShaped { get; set; }
        public decimal HandlingFee { get; set; }
        public bool ShippingDiscountDomestic { get; set; }
        public int ShippingService1 { get; set; }
        public decimal ShippingServiceCost1 { get; set; }
        public int ShippingService2 { get; set; }
        public decimal ShippingServiceCost2 { get; set; }
        public int ShippingService3 { get; set; }
        public decimal ShippingServiceCost3 { get; set; }
        public int IntShippingService1 { get; set; }
        public decimal IntShippingServiceCost1 { get; set; }
        public int IntShippingService2 { get; set; }
        public decimal IntShippingServiceCost2 { get; set; }
        public int IntShippingService3 { get; set; }
        public decimal IntShippingServiceCost3 { get; set; }
        public string IntShipToLocation1 { get; set; }
        public string IntShipToLocation2 { get; set; }
        public string IntShipToLocation3 { get; set; }
        public int DispatchTimeMax { get; set; }
        public int SiteId { get; set; }
        public short InternationalShippingType { get; set; }
        public decimal InternationalHandlingFee { get; set; }
        public bool ShippingDiscountInternational { get; set; }
        public bool ApplyDomesticShippingDiscountProfileId { get; set; }
        public bool ApplyInternationalShippingDiscountProfileId { get; set; }
        public int OrdinalId { get; set; }
        public decimal ShippingServiceAdditionalCost1 { get; set; }
        public decimal ShippingServiceAdditionalCost2 { get; set; }
        public decimal ShippingServiceAdditionalCost3 { get; set; }
        public decimal IntShippingServiceAdditionalCost1 { get; set; }
        public decimal IntShippingServiceAdditionalCost2 { get; set; }
        public decimal IntShippingServiceAdditionalCost3 { get; set; }
        public decimal Surcharge1 { get; set; }
        public decimal Surcharge2 { get; set; }
        public decimal Surcharge3 { get; set; }
        public bool FreeShipping { get; set; }
        public string DomesticShippingDiscountProfileId { get; set; }
        public string InternationalShippingDiscountProfileId { get; set; }
        public decimal BidstartShippingCost { get; set; }
        public decimal BidstartShippingCostTier2 { get; set; }
        public decimal BidstartShippingCostInt { get; set; }
        public bool? BidstartShippingDiscount { get; set; }
        public string BidstartInsuranceOption { get; set; }
        public decimal BidstartInsuranceCost { get; set; }
        public string BidstartShippingService { get; set; }
        public string ShippingDetails { get; set; }
        public bool ShipInternational { get; set; }
        public int ShippingService4 { get; set; }
        public decimal ShippingServiceCost4 { get; set; }
        public decimal ShippingServiceAdditionalCost4 { get; set; }
        public int IntShippingService4 { get; set; }
        public decimal IntShippingServiceCost4 { get; set; }
        public decimal IntShippingServiceAdditionalCost4 { get; set; }
        public string IntShipToLocation4 { get; set; }
        public int IntShippingService5 { get; set; }
        public decimal IntShippingServiceCost5 { get; set; }
        public decimal IntShippingServiceAdditionalCost5 { get; set; }
        public string IntShipToLocation5 { get; set; }
        public decimal Surcharge4 { get; set; }
        public bool GlobalShipping { get; set; }
        public bool MercadoLocalPickup { get; set; }
        public string MercadoShippingMethods { get; set; }
        public int MercadoFreeShippingServiceId { get; set; }
        public string ExcludeShipToLocation { get; set; }
        public byte ExcludeType { get; set; }
        public string ShipToLocation { get; set; }
        public bool DomesticShippingRateTable { get; set; }
        public bool InternationalShippingRateTable { get; set; }
        public bool EligibleForPickupDropOff { get; set; }
        public long DomesticShippingRateTableId { get; set; }
        public long InternationalShippingRateTableId { get; set; }
        public int SellerAccountsEbayId { get; set; }

        public virtual ICollection<ItemsBidstart> ItemsBidstart { get; set; }
        public virtual ICollection<ItemsEbay> ItemsEbay { get; set; }
        public virtual ICollection<ItemsMercado> ItemsMercado { get; set; }
        public virtual ICollection<Listings> Listings { get; set; }
    }
}
