using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class InventoryFeeds
    {
        public int InventoryId { get; set; }
        public int FeedId { get; set; }
        public int MessageId { get; set; }

        public virtual Feeds Feed { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
