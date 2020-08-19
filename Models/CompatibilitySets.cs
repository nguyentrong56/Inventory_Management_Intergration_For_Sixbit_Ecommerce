using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class CompatibilitySets
    {
        public CompatibilitySets()
        {
            ItemsEbay = new HashSet<ItemsEbay>();
            ListingsEbay = new HashSet<ListingsEbay>();
        }

        public int CompatibilitySetId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string CompatibilitySetDefinition { get; set; }
        public int OrdinalId { get; set; }

        public virtual ICollection<ItemsEbay> ItemsEbay { get; set; }
        public virtual ICollection<ListingsEbay> ListingsEbay { get; set; }
    }
}
