using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class EmailTemplates
    {
        public int EmailTemplateId { get; set; }
        public string Name { get; set; }
        public string HtmlContent { get; set; }
        public string Subject { get; set; }
        public int OrdinalId { get; set; }
        public bool? IsCustom { get; set; }
        public string KeyName { get; set; }
    }
}
