using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class TagTemplates
    {
        public int TagTemplateId { get; set; }
        public string Name { get; set; }
        public string TagList { get; set; }
        public int OrdinalId { get; set; }
    }
}
