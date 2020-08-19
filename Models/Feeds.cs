using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Feeds
    {
        public Feeds()
        {
            InventoryFeeds = new HashSet<InventoryFeeds>();
            OrdersFeeds = new HashSet<OrdersFeeds>();
        }

        public int FeedId { get; set; }
        public int SiteId { get; set; }
        public decimal ExternalFeedId { get; set; }
        public int FeedType { get; set; }
        public int StatusId { get; set; }
        public DateTime SubmittedDate { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public int ItemCount { get; set; }

        public virtual ICollection<InventoryFeeds> InventoryFeeds { get; set; }
        public virtual ICollection<OrdersFeeds> OrdersFeeds { get; set; }
    }
}
