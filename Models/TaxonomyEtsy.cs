using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class TaxonomyEtsy
    {
        public TaxonomyEtsy()
        {
            ItemsEtsy = new HashSet<ItemsEtsy>();
        }

        public int TaxonomyEtsyId { get; set; }
        public long CategoryId { get; set; }
        public short Level { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
        public int ParentId { get; set; }
        public string Path { get; set; }
        public string PropertySet { get; set; }
        public string CustomPropertySet { get; set; }

        public virtual ICollection<ItemsEtsy> ItemsEtsy { get; set; }
    }
}
