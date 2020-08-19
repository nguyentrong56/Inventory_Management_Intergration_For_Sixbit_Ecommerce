using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Pictures
    {
        public int PictureId { get; set; }
        public int ItemId { get; set; }
        public string Title { get; set; }
        public int OrdinalId { get; set; }
        public string PictureUrl { get; set; }
        public bool IsVariationPicture { get; set; }
        public string VariationSpecificNameValue { get; set; }
        public byte[] Picture { get; set; }
        public byte[] Thumbnail { get; set; }
        public bool IsManualUrl { get; set; }
        public string ManualPictureUrl { get; set; }
        public string PictureIdetsy { get; set; }
        public DateTime? DateLastUploaded { get; set; }
        public bool PendingDownload { get; set; }
        public bool IsWatermarked { get; set; }
        public string PictureUrletsy { get; set; }
        public long PictureIdshopify { get; set; }
        public string PictureUrlshopify { get; set; }

        public virtual Items Item { get; set; }
    }
}
