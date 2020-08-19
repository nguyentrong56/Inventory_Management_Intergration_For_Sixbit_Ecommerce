using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ChangeDetails
    {
        public int ChangeDetailsId { get; set; }
        public int ChangeId { get; set; }
        public long EntityId { get; set; }
        public int ChangeType { get; set; }
        public int Action { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public virtual Changes Change { get; set; }
    }
}
