using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class GridLayouts
    {
        public int GridLayoutId { get; set; }
        public string KeyName { get; set; }
        public string Name { get; set; }
        public string LayoutType { get; set; }
        public int OrdinalId { get; set; }
        public string GridSettings { get; set; }
        public string GridSettingsBaseline { get; set; }
    }
}
