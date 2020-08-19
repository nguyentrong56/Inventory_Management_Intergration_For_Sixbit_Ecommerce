using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class BillChargesEtsy
    {
        public long BillChargeId { get; set; }
        public int SellerAccountsEtsyId { get; set; }
        public int Type { get; set; }
        public long TypeId { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime? CreationTimestamp { get; set; }
        public DateTime? LastModifiedTimestamp { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual SellerAccountsEtsy SellerAccountsEtsy { get; set; }
    }
}
