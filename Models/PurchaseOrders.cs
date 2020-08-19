using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class PurchaseOrders
    {
        public PurchaseOrders()
        {
            PurchaseOrderDetails = new HashSet<PurchaseOrderDetails>();
        }

        public int PurchaseOrderId { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public int SupplierId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public string OrderedBy { get; set; }
        public string Carrier { get; set; }
        public string TrackingNumber { get; set; }
        public int OriginTemplateId { get; set; }

        public virtual OriginTemplates OriginTemplate { get; set; }
        public virtual Suppliers Supplier { get; set; }
        public virtual ICollection<PurchaseOrderDetails> PurchaseOrderDetails { get; set; }
    }
}
