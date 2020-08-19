using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ItemSpecificsEbay
    {
        public int CategoryId { get; set; }
        public string RecommendedItemSpecifics { get; set; }
        public string UserItemSpecifics { get; set; }
        public DateTime? RecommendedUpdateDate { get; set; }
        public bool CatalogEnabled { get; set; }
        public int Csid { get; set; }
        public DateTime? CatalogEnabledUpdateDate { get; set; }
        public string CatalogSearchCriteria { get; set; }
        public DateTime? CatalogSearchCriteriaUpdateDate { get; set; }
    }
}
