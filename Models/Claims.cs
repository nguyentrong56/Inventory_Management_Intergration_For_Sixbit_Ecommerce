using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Claims
    {
        public int ClaimId { get; set; }
        public int StatusId { get; set; }
        public int? ShipmentId { get; set; }
        public int? OrderId { get; set; }
        public string Description { get; set; }
        public DateTime? FiledDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int ClaimType { get; set; }
        public DateTime? DiscoverDate { get; set; }
        public decimal ClaimAmount { get; set; }
        public string SsclaimId { get; set; }
        public string SsclaimRetrievalCode { get; set; }
        public DateTime? PaymentReceivedDate { get; set; }
    }
}
