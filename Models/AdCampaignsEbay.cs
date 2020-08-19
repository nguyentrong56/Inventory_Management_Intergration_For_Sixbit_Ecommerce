using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class AdCampaignsEbay
    {
        public AdCampaignsEbay()
        {
            AdsEbay = new HashSet<AdsEbay>();
        }

        public long CampaignId { get; set; }
        public int SellerAccountEbayId { get; set; }
        public string CampaignContents { get; set; }
        public string CampaignName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual SellerAccountseBay SellerAccountEbay { get; set; }
        public virtual ICollection<AdsEbay> AdsEbay { get; set; }
    }
}
