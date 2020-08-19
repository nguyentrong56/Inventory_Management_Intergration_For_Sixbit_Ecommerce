using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ReallocateReference
    {
        public int ItemId { get; set; }
        public int ListingId { get; set; }

        public virtual Items Item { get; set; }
        public virtual Listings Listing { get; set; }
    }
}
