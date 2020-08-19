using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ListingUpgradeTemplates
    {
        public ListingUpgradeTemplates()
        {
            ItemsBidstart = new HashSet<ItemsBidstart>();
            ItemsEbay = new HashSet<ItemsEbay>();
            Listings = new HashSet<Listings>();
        }

        public int ListingUpgradeTemplateId { get; set; }
        public string Name { get; set; }
        public bool Bold { get; set; }
        public bool Border { get; set; }
        public bool HomePageFeatured { get; set; }
        public bool FeaturedPlus { get; set; }
        public bool Highlight { get; set; }
        public bool GalleryPlus { get; set; }
        public bool GiftServices { get; set; }
        public bool GiftWrap { get; set; }
        public bool ExpressShip { get; set; }
        public bool ShipToRecipient { get; set; }
        public bool ProPackBundle { get; set; }
        public int OrdinalId { get; set; }
        public bool Isv { get; set; }
        public bool Isvuk { get; set; }
        public bool IsvnorthAmerica { get; set; }
        public bool FeaturedFirst { get; set; }
        public bool ValuePackBundle { get; set; }
        public bool TipFeatured { get; set; }
        public bool CategoryFeatured { get; set; }

        public virtual ICollection<ItemsBidstart> ItemsBidstart { get; set; }
        public virtual ICollection<ItemsEbay> ItemsEbay { get; set; }
        public virtual ICollection<Listings> Listings { get; set; }
    }
}
