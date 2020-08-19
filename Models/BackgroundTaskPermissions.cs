using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class BackgroundTaskPermissions
    {
        public string ComputerName { get; set; }
        public bool AgentEnabled { get; set; }
        public DateTime? LastConnectedDate { get; set; }
    }
}
