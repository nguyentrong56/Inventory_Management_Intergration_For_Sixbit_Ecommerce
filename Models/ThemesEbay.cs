using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ThemesEbay
    {
        public int ThemeId { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public string ThemeTop { get; set; }
        public string ThemeUserCellTop { get; set; }
        public string ThemeUserContent { get; set; }
        public string ThemeUserCellBottom { get; set; }
        public string ThemeBottom { get; set; }
        public int SiteId { get; set; }
        public byte[] Thumbnail { get; set; }
        public short? Level { get; set; }
        public bool IsDuplicate { get; set; }
    }
}
