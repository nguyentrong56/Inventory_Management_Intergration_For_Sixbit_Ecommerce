using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class EBayBusinessPolicies
    {
        public long EBayBusinessPolicyId { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public string SellerAccount { get; set; }
        public string PolicyInfo { get; set; }
    }
}
