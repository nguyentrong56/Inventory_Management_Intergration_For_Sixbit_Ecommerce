using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Views
    {
        public int ViewId { get; set; }
        public string Name { get; set; }
        public string Mode { get; set; }
        public bool Deleteable { get; set; }
        public bool Editable { get; set; }
        public string SearchQuery { get; set; }
        public int OrdinalId { get; set; }
        public string KeyName { get; set; }
        public int UserLoginId { get; set; }
        public string ConditionXml { get; set; }
        public bool IncludeRetired { get; set; }
        public int SiteId { get; set; }
        public int? GridLayoutId { get; set; }
    }
}
