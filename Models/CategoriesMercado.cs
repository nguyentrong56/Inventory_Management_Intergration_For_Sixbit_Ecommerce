using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class CategoriesMercado
    {
        public CategoriesMercado()
        {
            ItemsMercado = new HashSet<ItemsMercado>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int CategoryParentId { get; set; }
        public string CategoryFeatures { get; set; }
        public int CategoryLevel { get; set; }
        public bool LeafCategory { get; set; }
        public DateTime? FeatureUpdateDate { get; set; }
        public bool Modified { get; set; }

        public virtual ICollection<ItemsMercado> ItemsMercado { get; set; }
    }
}
