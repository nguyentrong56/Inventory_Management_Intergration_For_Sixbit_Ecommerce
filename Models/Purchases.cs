using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Purchases
    {
        public Purchases()
        {
            SalesPurchases = new HashSet<SalesPurchases>();
        }

        public int PurchaseId { get; set; }
        public int InventoryId { get; set; }
        public int Quantity { get; set; }
        public DateTime? DatePurchased { get; set; }
        public double Cost { get; set; }
        public int ShrinkCount { get; set; }
        public int? SupplierId { get; set; }
        public int? PurchaseSource { get; set; }
        public string Ponumber { get; set; }
        public string InvoiceNumber { get; set; }
        public byte FulfillmentSource { get; set; }
        public long? ShopifyLocationId { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual LocationsShopify ShopifyLocation { get; set; }
        public virtual Suppliers Supplier { get; set; }
        public virtual ICollection<SalesPurchases> SalesPurchases { get; set; }
    }
}
