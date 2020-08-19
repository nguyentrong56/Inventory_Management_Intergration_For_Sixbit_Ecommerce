using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class LocationKeyLink
    {
        public int BusinessProfileId { get; set; }
        public int OriginTemplateId { get; set; }
        public string LocationKey { get; set; }

        public virtual BusinessProfile BusinessProfile { get; set; }
        public virtual OriginTemplates OriginTemplate { get; set; }
    }
}
