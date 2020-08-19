using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class MaterialTemplates
    {
        public int MaterialTemplateId { get; set; }
        public string Name { get; set; }
        public string MaterialList { get; set; }
        public int OrdinalId { get; set; }
    }
}
