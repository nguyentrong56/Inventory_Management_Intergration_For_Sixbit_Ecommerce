using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ItemPromotionsEbay
    {
        public int ItemPromotionId { get; set; }
        public string PromotionId { get; set; }
        public int SellerAccountsEbayId { get; set; }
        public string PromotionContents { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public int PromotionType { get; set; }

        public virtual SellerAccountseBay SellerAccountsEbay { get; set; }
    }
}
