using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class OrdersFeeds
    {
        public int OrderId { get; set; }
        public int FeedId { get; set; }
        public int MessageId { get; set; }

        public virtual Feeds Feed { get; set; }
        public virtual Orders Order { get; set; }
    }
}
