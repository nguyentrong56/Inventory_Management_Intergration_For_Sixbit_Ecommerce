using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class PostageImages
    {
        public int PostageImageId { get; set; }
        public int ShipmentId { get; set; }
        public byte[] PostageImage { get; set; }
    }
}
