using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class CategoriesAmazonSpecificsValues
    {
        public int SpecificId { get; set; }
        public string Value { get; set; }
        public int OrdinalId { get; set; }

        public virtual CategoriesAmazonSpecifics Specific { get; set; }
    }
}
