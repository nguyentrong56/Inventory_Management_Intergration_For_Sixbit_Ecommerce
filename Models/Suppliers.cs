using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Suppliers
    {
        public Suppliers()
        {
            PurchaseOrders = new HashSet<PurchaseOrders>();
            Purchases = new HashSet<Purchases>();
        }

        public int SupplierId { get; set; }
        public string AccountNum { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Initial { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public int AddressId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Notes { get; set; }
        public string Title { get; set; }
        public string WebAddress { get; set; }
        public bool IsConsignor { get; set; }
        public int ConsignmentPlanId { get; set; }
        public bool IsAutoPay { get; set; }
        public string AutoPayEmailAddress { get; set; }
        public int OriginTemplateId { get; set; }
        public DateTime? DateLastModified { get; set; }
        public bool? IsActive { get; set; }

        public virtual OriginTemplates OriginTemplate { get; set; }
        public virtual ICollection<PurchaseOrders> PurchaseOrders { get; set; }
        public virtual ICollection<Purchases> Purchases { get; set; }
    }
}
