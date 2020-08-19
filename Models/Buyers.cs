using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Buyers
    {
        public int BuyerId { get; set; }
        public string Email { get; set; }
        public string EBayUserid { get; set; }
        public string FirstName { get; set; }
        public string Initial { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public int BillingAddressId { get; set; }
        public int ShippingAddressId { get; set; }
        public string Notes { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string SalesTaxId { get; set; }
        public DateTime? DateLastModified { get; set; }
        public string Title { get; set; }
        public string WebAddress { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string BidstartUserId { get; set; }
        public string EtsyUserId { get; set; }
        public string AmazonUserId { get; set; }
        public string MercadoUserId { get; set; }
        public int MercadoUserIdint { get; set; }
        public long ShopifyBuyerId { get; set; }
    }
}
