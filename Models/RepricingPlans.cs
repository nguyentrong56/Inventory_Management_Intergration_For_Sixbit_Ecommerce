using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class RepricingPlans
    {
        public RepricingPlans()
        {
            ItemsAmazon = new HashSet<ItemsAmazon>();
            ItemsBidstart = new HashSet<ItemsBidstart>();
            ItemsEbay = new HashSet<ItemsEbay>();
            ItemsEtsy = new HashSet<ItemsEtsy>();
            ItemsMercado = new HashSet<ItemsMercado>();
        }

        public int RepricingPlanId { get; set; }
        public string Name { get; set; }
        public int OrdinalId { get; set; }

        public virtual ICollection<ItemsAmazon> ItemsAmazon { get; set; }
        public virtual ICollection<ItemsBidstart> ItemsBidstart { get; set; }
        public virtual ICollection<ItemsEbay> ItemsEbay { get; set; }
        public virtual ICollection<ItemsEtsy> ItemsEtsy { get; set; }
        public virtual ICollection<ItemsMercado> ItemsMercado { get; set; }
    }
}
