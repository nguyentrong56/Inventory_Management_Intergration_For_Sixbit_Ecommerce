using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class StoreCategoriesEbay
    {
        public long StoreCategoryId { get; set; }
        public long ParentId { get; set; }
        public int Order { get; set; }
        public string StoreCategoryName { get; set; }
        public string SellerAccount { get; set; }
    }
}
