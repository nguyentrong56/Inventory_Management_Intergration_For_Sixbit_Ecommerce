using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ActivityLog
    {
        public int LogId { get; set; }
        public byte LogType { get; set; }
        public byte LogCode { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }
        public DateTime? LogTime { get; set; }
    }
}
