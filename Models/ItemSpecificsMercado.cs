using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ItemSpecificsMercado
    {
        public int CategoryId { get; set; }
        public string RecommendedItemSpecifics { get; set; }
        public DateTime? RecommendedUpdateDate { get; set; }
    }
}
