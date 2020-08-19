using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class SellerAccountsMercado
    {
        public SellerAccountsMercado()
        {
            BusinessProfile = new HashSet<BusinessProfile>();
        }

        public int SellerAccountsMercadoId { get; set; }
        public string UserId { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string SellerRefreshDetails { get; set; }
        public string BuyerMessageDetails { get; set; }
        public string UserIdnumber { get; set; }
        public int StoreId { get; set; }

        public virtual ICollection<BusinessProfile> BusinessProfile { get; set; }
    }
}
