using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class SalesPurchases
    {
        public int SaleId { get; set; }
        public int PurchaseId { get; set; }
        public int QtySold { get; set; }
        public int QtyShrink { get; set; }

        public virtual Purchases Purchase { get; set; }
        public virtual Sales Sale { get; set; }
    }
}
