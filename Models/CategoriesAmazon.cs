using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class CategoriesAmazon
    {
        public CategoriesAmazon()
        {
            CategoriesAmazonSpecifics = new HashSet<CategoriesAmazonSpecifics>();
            ItemsAmazon = new HashSet<ItemsAmazon>();
        }

        public long CategoryId { get; set; }
        public short Level { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }
        public long ParentId { get; set; }
        public string Path { get; set; }
        public int CategoriesAmazonId { get; set; }
        public string Refinements { get; set; }

        public virtual ICollection<CategoriesAmazonSpecifics> CategoriesAmazonSpecifics { get; set; }
        public virtual ICollection<ItemsAmazon> ItemsAmazon { get; set; }
    }
}
