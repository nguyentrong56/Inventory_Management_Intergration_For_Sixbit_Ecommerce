using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class VariationSets
    {
        public VariationSets()
        {
            Items = new HashSet<Items>();
        }

        public int VariationSetId { get; set; }
        public string Variations { get; set; }
        public string Name { get; set; }
        public int PictureIndex { get; set; }

        public virtual ICollection<Items> Items { get; set; }
    }
}
