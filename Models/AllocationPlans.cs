using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class AllocationPlans
    {
        public AllocationPlans()
        {
            ItemsAmazon = new HashSet<ItemsAmazon>();
            ItemsBidstart = new HashSet<ItemsBidstart>();
            ItemsEbay = new HashSet<ItemsEbay>();
            ItemsEtsy = new HashSet<ItemsEtsy>();
            ItemsMercado = new HashSet<ItemsMercado>();
            ItemsShopify = new HashSet<ItemsShopify>();
        }

        public int AllocationPlanId { get; set; }
        public string Name { get; set; }
        public int OrdinalId { get; set; }
        public bool IsAutoFp { get; set; }
        public byte AutoFptype { get; set; }
        public int ConstantFpqty { get; set; }
        public bool IsAutoAuction { get; set; }
        public bool IsDecliningFp { get; set; }
        public byte DecliningFptype { get; set; }
        public decimal DecliningFpamount { get; set; }
        public decimal Fpfloor { get; set; }
        public int ReserveQty { get; set; }
        public bool OverrideOutOfStock { get; set; }

        public virtual ICollection<ItemsAmazon> ItemsAmazon { get; set; }
        public virtual ICollection<ItemsBidstart> ItemsBidstart { get; set; }
        public virtual ICollection<ItemsEbay> ItemsEbay { get; set; }
        public virtual ICollection<ItemsEtsy> ItemsEtsy { get; set; }
        public virtual ICollection<ItemsMercado> ItemsMercado { get; set; }
        public virtual ICollection<ItemsShopify> ItemsShopify { get; set; }
    }
}
