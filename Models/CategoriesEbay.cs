using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class CategoriesEbay
    {
        public CategoriesEbay()
        {
            ItemsEbayCategory1Navigation = new HashSet<ItemsEbay>();
            ItemsEbayCategory2Navigation = new HashSet<ItemsEbay>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int CategoryParentId { get; set; }
        public bool CustomIs { get; set; }
        public string CategoryFeatures { get; set; }
        public int CategoryLevel { get; set; }
        public bool LeafCategory { get; set; }
        public DateTime? FeatureUpdateDate { get; set; }
        public bool Modified { get; set; }
        public bool? VariationsEnabled { get; set; }
        public string Aspects { get; set; }
        public DateTime? AspectsUpdated { get; set; }
        public bool ProductRequired { get; set; }
        public string Exclusions { get; set; }

        public virtual ICollection<ItemsEbay> ItemsEbayCategory1Navigation { get; set; }
        public virtual ICollection<ItemsEbay> ItemsEbayCategory2Navigation { get; set; }
    }
}
