using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class AdsEbay
    {
        public AdsEbay()
        {
            ListingsEbay = new HashSet<ListingsEbay>();
        }

        public long AdId { get; set; }
        public long CampaignId { get; set; }

        public virtual AdCampaignsEbay Campaign { get; set; }
        public virtual ICollection<ListingsEbay> ListingsEbay { get; set; }
    }
}
