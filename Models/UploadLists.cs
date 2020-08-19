using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class UploadLists
    {
        public int UploadListId { get; set; }
        public string Name { get; set; }
        public int OrdinalId { get; set; }
        public bool? IsCustom { get; set; }
        public bool IsHidden { get; set; }
        public int? GridLayoutId { get; set; }
    }
}
