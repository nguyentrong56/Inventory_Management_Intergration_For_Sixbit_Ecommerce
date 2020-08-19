using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class UserLogins
    {
        public UserLogins()
        {
            Changes = new HashSet<Changes>();
        }

        public int UserLoginId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool Administrator { get; set; }
        public string Settings { get; set; }
        public string ItemsGridSettings { get; set; }
        public string ListingsGridSettings { get; set; }
        public string OrdersGridSettings { get; set; }
        public string BuyersGridSettings { get; set; }
        public string Permissions { get; set; }

        public virtual ICollection<Changes> Changes { get; set; }
    }
}
