using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class SellerAccountseBay
    {
        public SellerAccountseBay()
        {
            AdCampaignsEbay = new HashSet<AdCampaignsEbay>();
            BusinessProfile = new HashSet<BusinessProfile>();
            Dsrs = new HashSet<Dsrs>();
            ItemPromotionsEbay = new HashSet<ItemPromotionsEbay>();
        }

        public string SellerAccount { get; set; }
        public string Token { get; set; }
        public bool StoreOwner { get; set; }
        public string StoreSite { get; set; }
        public string StoreUrl { get; set; }
        public string Email { get; set; }
        public string PayPalAccountLevel { get; set; }
        public string PayPalAccountStatus { get; set; }
        public string PayPalAccountType { get; set; }
        public string SellerPaymentAddress { get; set; }
        public short? SiteId { get; set; }
        public string SkypeId { get; set; }
        public string Status { get; set; }
        public string UserSubscriptions { get; set; }
        public bool GoodStanding { get; set; }
        public string CombinedPaymentPreferences { get; set; }
        public string EndOfAuctionEmailPreferences { get; set; }
        public string SellerPaymentPreferences { get; set; }
        public string SellerRoleMetrics { get; set; }
        public string PositiveFeedbackPeriodArray { get; set; }
        public string NeutralFeedbackPeriodArray { get; set; }
        public string NegativeFeedbackPeriodArray { get; set; }
        public string TotalFeedbackPeriodArray { get; set; }
        public int NeutralCommentCountFromSuspendedUsers { get; set; }
        public int UniquePositiveFeedbackCount { get; set; }
        public int UniqueNeutralFeedbackCount { get; set; }
        public string BuyerSatisfactionAlerts { get; set; }
        public string PolicyComplianceAlerts { get; set; }
        public string PowerSellerStatusAlerts { get; set; }
        public string SellerAccountAlerts { get; set; }
        public string SearchStanding { get; set; }
        public decimal SellerFeeDiscount { get; set; }
        public int UniqueNegativeFeedbackCount { get; set; }
        public bool QualifiedForFixedPriceOneDayDuration { get; set; }
        public bool QualifiesForSelling { get; set; }
        public bool QualifiesForBuyItNow { get; set; }
        public bool QualifiesForBuyItNowMultiple { get; set; }
        public DateTime? LastRefresh { get; set; }
        public string TopRatedSellerDetails { get; set; }
        public bool TopRatedSeller { get; set; }
        public string SellerRefreshDetails { get; set; }
        public int SellerAccountsEbayId { get; set; }
        public string BuyerMessageDetails { get; set; }
        public bool BusinessPoliciesOptedIn { get; set; }
        public bool UseOutOfStockControl { get; set; }
        public bool UseStrikethroughPricing { get; set; }
        public DateTime? RefreshTokenExpireDate { get; set; }
        public string RefreshToken { get; set; }
        public string AccessToken { get; set; }
        public DateTime? AccessTokenExpireDate { get; set; }
        public string ListingViolationsSummary { get; set; }
        public bool UseManagedPayments { get; set; }
        public bool? Enabled { get; set; }

        public virtual ICollection<AdCampaignsEbay> AdCampaignsEbay { get; set; }
        public virtual ICollection<BusinessProfile> BusinessProfile { get; set; }
        public virtual ICollection<Dsrs> Dsrs { get; set; }
        public virtual ICollection<ItemPromotionsEbay> ItemPromotionsEbay { get; set; }
    }
}
