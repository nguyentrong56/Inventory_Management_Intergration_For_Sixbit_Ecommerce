using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class OriginTemplates
    {
        public OriginTemplates()
        {
            BusinessProfile = new HashSet<BusinessProfile>();
            Items = new HashSet<Items>();
            LocationKeyLink = new HashSet<LocationKeyLink>();
            PurchaseOrders = new HashSet<PurchaseOrders>();
            Shipments = new HashSet<Shipments>();
            Suppliers = new HashSet<Suppliers>();
        }

        public int OriginTemplateId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string CountryId { get; set; }
        public string PostalCode { get; set; }
        public int OrdinalId { get; set; }
        public int ReturnAddressId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string LocationAdditionalInformation { get; set; }
        public string LocationInstructions { get; set; }
        public int LocationTypes { get; set; }
        public string LocationWebUrl { get; set; }
        public int LocationStatus { get; set; }
        public string OperatingHours { get; set; }
        public string SpecialHours { get; set; }

        public virtual Addresses ReturnAddress { get; set; }
        public virtual ICollection<BusinessProfile> BusinessProfile { get; set; }
        public virtual ICollection<Items> Items { get; set; }
        public virtual ICollection<LocationKeyLink> LocationKeyLink { get; set; }
        public virtual ICollection<PurchaseOrders> PurchaseOrders { get; set; }
        public virtual ICollection<Shipments> Shipments { get; set; }
        public virtual ICollection<Suppliers> Suppliers { get; set; }
    }
}
