using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class BatchChangeDefinitions
    {
        public int BatchChangeDefinitionId { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public int Mode { get; set; }
        public string ItemSpecificsXml { get; set; }
        public int OrdinalId { get; set; }
    }
}
