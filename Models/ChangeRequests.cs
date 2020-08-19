using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ChangeRequests
    {
        public string ChangeRequestId { get; set; }
        public int InventoryId { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
        public string Result { get; set; }

        public virtual Inventory Inventory { get; set; }
    }
}
