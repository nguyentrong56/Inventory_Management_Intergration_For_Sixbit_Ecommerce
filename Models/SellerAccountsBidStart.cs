using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class SellerAccountsBidStart
    {
        public SellerAccountsBidStart()
        {
            BusinessProfile = new HashSet<BusinessProfile>();
        }

        public int SellerAccountsBidStartId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string SellerRefreshDetails { get; set; }
        public string Token { get; set; }

        public virtual ICollection<BusinessProfile> BusinessProfile { get; set; }
    }
}
