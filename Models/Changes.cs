using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Changes
    {
        public Changes()
        {
            ChangeDetails = new HashSet<ChangeDetails>();
        }

        public int ChangeId { get; set; }
        public int Operation { get; set; }
        public int UserLoginId { get; set; }
        public DateTime ChangeDate { get; set; }
        public string Notes { get; set; }

        public virtual UserLogins UserLogin { get; set; }
        public virtual ICollection<ChangeDetails> ChangeDetails { get; set; }
    }
}
