using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class BuyerMessages
    {
        public int BuyerMessageId { get; set; }
        public int SiteId { get; set; }
        public string SellerAccount { get; set; }
        public string ECommerceId { get; set; }
        public string Subject { get; set; }
        public string FromBuyer { get; set; }
        public string Title { get; set; }
        public DateTime? CreationDate { get; set; }
        public string MessageId { get; set; }
        public string Body { get; set; }
        public byte MessageType { get; set; }
        public string UserIdnumber { get; set; }
        public bool Resolved { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
