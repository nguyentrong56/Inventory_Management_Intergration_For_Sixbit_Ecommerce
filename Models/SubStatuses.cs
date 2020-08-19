using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class SubStatuses
    {
        public int SubStatusId { get; set; }
        public string Name { get; set; }
        public int OrdinalId { get; set; }
        public int ParentStatusId { get; set; }
        public string Mode { get; set; }
        public string KeyName { get; set; }
        public bool? Deleteable { get; set; }
        public bool? Editable { get; set; }
        public int? GridLayoutId { get; set; }
    }
}
