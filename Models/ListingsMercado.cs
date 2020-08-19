using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ListingsMercado
    {
        public int ListingMercadoId { get; set; }
        public string SubTitle { get; set; }
        public int Category1 { get; set; }
        public string ItemSpecifics { get; set; }
        public int MissingSalesCount { get; set; }
        public bool PictureResize { get; set; }
        public short PictureSize { get; set; }
        public bool SelfHostPictures { get; set; }
        public string CatalogSummary { get; set; }
        public bool CatalogItem { get; set; }
        public int EndReasonCode { get; set; }
        public int ListingIdlink { get; set; }
        public string Warranty { get; set; }
        public string VideoLink { get; set; }

        public virtual Listings ListingIdlinkNavigation { get; set; }
    }
}
