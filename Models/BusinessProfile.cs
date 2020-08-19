using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class BusinessProfile
    {
        public BusinessProfile()
        {
            Items = new HashSet<Items>();
            Listings = new HashSet<Listings>();
            LocationKeyLink = new HashSet<LocationKeyLink>();
            Orders = new HashSet<Orders>();
        }

        public int BusinessProfileId { get; set; }
        public string BusinessName { get; set; }
        public int ContactAccountId { get; set; }
        public int OriginTemplateId { get; set; }
        public byte[] Logo { get; set; }
        public int PictureHostId { get; set; }
        public int SellerAccountseBayId { get; set; }
        public int SellerAccountsBidStartId { get; set; }
        public int SellerAccountsEtsyId { get; set; }
        public string PackingListMsg { get; set; }
        public string PackingListMsg2 { get; set; }
        public int SellerAccountsMercadoId { get; set; }
        public int SellerAccountsAmazonId { get; set; }
        public string ContactAccountMappings { get; set; }
        public int SellerAccountsShopifyId { get; set; }

        public virtual ContactAccounts ContactAccount { get; set; }
        public virtual OriginTemplates OriginTemplate { get; set; }
        public virtual PictureHosts PictureHost { get; set; }
        public virtual SellerAccountsAmazon SellerAccountsAmazon { get; set; }
        public virtual SellerAccountsBidStart SellerAccountsBidStart { get; set; }
        public virtual SellerAccountsEtsy SellerAccountsEtsy { get; set; }
        public virtual SellerAccountsMercado SellerAccountsMercado { get; set; }
        public virtual SellerAccountsShopify SellerAccountsShopify { get; set; }
        public virtual SellerAccountseBay SellerAccountseBay { get; set; }
        public virtual ICollection<Items> Items { get; set; }
        public virtual ICollection<Listings> Listings { get; set; }
        public virtual ICollection<LocationKeyLink> LocationKeyLink { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
