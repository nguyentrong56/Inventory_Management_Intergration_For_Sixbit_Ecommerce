using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ShopSectionsEtsy
    {
        public ShopSectionsEtsy()
        {
            ItemsEtsy = new HashSet<ItemsEtsy>();
        }

        public long ShopSectionId { get; set; }
        public string Title { get; set; }
        public int Rank { get; set; }
        public int SellerAccountsEtsyId { get; set; }
        public int OrdinalId { get; set; }

        public virtual SellerAccountsEtsy SellerAccountsEtsy { get; set; }
        public virtual ICollection<ItemsEtsy> ItemsEtsy { get; set; }
    }
}
