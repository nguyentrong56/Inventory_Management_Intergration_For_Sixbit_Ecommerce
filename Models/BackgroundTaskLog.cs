using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class BackgroundTaskLog
    {
        public int LogId { get; set; }
        public string TaskName { get; set; }
        public DateTime ExecTime { get; set; }
        public string ComputerName { get; set; }
        public DateTime? StartedTime { get; set; }
        public DateTime? CompTime { get; set; }
        public int NumberAffected { get; set; }
        public string Status { get; set; }

        public virtual BackgroundTaskList TaskNameNavigation { get; set; }
    }
}
