using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class BackgroundTaskList
    {
        public BackgroundTaskList()
        {
            BackgroundTaskLog = new HashSet<BackgroundTaskLog>();
        }

        public string TaskName { get; set; }
        public int Frequency { get; set; }
        public bool Enabled { get; set; }
        public int Priority { get; set; }
        public string TaskComputer { get; set; }
        public DateTime? FixedTime { get; set; }

        public virtual ICollection<BackgroundTaskLog> BackgroundTaskLog { get; set; }
    }
}
