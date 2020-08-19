using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            OriginTemplates = new HashSet<OriginTemplates>();
            Shipments = new HashSet<Shipments>();
        }

        public int AddressId { get; set; }
        public string FirstName { get; set; }
        public string Initial { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string EBayAddressId { get; set; }
        public bool Overwrite { get; set; }
        public int BuyerId { get; set; }
        public int SupplierId { get; set; }
        public string CountryId { get; set; }
        public string StateId { get; set; }
        public string CityId { get; set; }
        public string MercadoAddressId { get; set; }
        public string ReferenceId { get; set; }
        public long ShopifyAddressId { get; set; }

        public virtual ICollection<OriginTemplates> OriginTemplates { get; set; }
        public virtual ICollection<Shipments> Shipments { get; set; }
    }
}
