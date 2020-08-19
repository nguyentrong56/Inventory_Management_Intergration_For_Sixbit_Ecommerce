using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class CategoriesBidStart
    {
        public CategoriesBidStart()
        {
            ItemsBidstartCategory1Navigation = new HashSet<ItemsBidstart>();
            ItemsBidstartCategory2Navigation = new HashSet<ItemsBidstart>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int CategoryParentId { get; set; }
        public int CategoryLevel { get; set; }
        public bool LeafCategory { get; set; }
        public short? Level { get; set; }
        public bool Modified { get; set; }

        public virtual ICollection<ItemsBidstart> ItemsBidstartCategory1Navigation { get; set; }
        public virtual ICollection<ItemsBidstart> ItemsBidstartCategory2Navigation { get; set; }
    }
}
