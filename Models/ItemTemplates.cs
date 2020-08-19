using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ItemTemplates
    {
        public int ItemTemplateId { get; set; }
        public int ItemId { get; set; }
        public int OrdinalId { get; set; }

        public virtual Items Item { get; set; }
    }
}
