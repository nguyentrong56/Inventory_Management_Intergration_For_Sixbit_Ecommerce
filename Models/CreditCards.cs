using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class CreditCards
    {
        public CreditCards()
        {
            Orders = new HashSet<Orders>();
        }

        public int Ccid { get; set; }
        public string Cctype { get; set; }
        public string Ccnumber { get; set; }
        public short CcexpMon { get; set; }
        public short CcexpYear { get; set; }
        public string Ccname { get; set; }
        public int BuyerId { get; set; }
        public bool Default { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
