using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Snippets
    {
        public string Name { get; set; }
        public string Snippet { get; set; }
        public int Type { get; set; }
        public bool? IsCustom { get; set; }
        public string GroupName { get; set; }
        public bool IsRawMode { get; set; }
        public int OrdinalId { get; set; }
    }
}
