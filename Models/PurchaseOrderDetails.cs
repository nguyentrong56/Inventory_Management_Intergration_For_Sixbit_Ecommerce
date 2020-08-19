using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class PurchaseOrderDetails
    {
        public int PurchaseOrderDetailsId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int InventoryId { get; set; }
        public int ReorderQty { get; set; }
        public int QtyReceived { get; set; }
        public decimal SupplierPrice { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual PurchaseOrders PurchaseOrder { get; set; }
    }
}
