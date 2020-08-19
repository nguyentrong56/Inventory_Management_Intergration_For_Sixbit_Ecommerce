using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Reports
    {
        public int ReportId { get; set; }
        public int OrdinalId { get; set; }
        public string Name { get; set; }
        public string KeyName { get; set; }
        public string Report { get; set; }
        public byte ReportType { get; set; }
        public string ParentReportKeyName { get; set; }
        public string BaselineReportKeyName { get; set; }
        public bool IsBaseline { get; set; }
        public bool? IsEditable { get; set; }
    }
}
