using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class CategoriesAmazonSpecifics
    {
        public CategoriesAmazonSpecifics()
        {
            CategoriesAmazonSpecificsValues = new HashSet<CategoriesAmazonSpecificsValues>();
        }

        public int SpecificId { get; set; }
        public int CategoriesAmazonId { get; set; }
        public string Name { get; set; }

        public virtual CategoriesAmazon CategoriesAmazon { get; set; }
        public virtual ICollection<CategoriesAmazonSpecificsValues> CategoriesAmazonSpecificsValues { get; set; }
    }
}
