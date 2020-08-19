using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class LabelDefinitions
    {
        public int LabelDefinitionId { get; set; }
        public string Name { get; set; }
        public int OrdinalId { get; set; }
        public decimal PageWidth { get; set; }
        public decimal PageHeight { get; set; }
        public bool? IsPortrait { get; set; }
        public byte ColumnCount { get; set; }
        public decimal ColumnSpacing { get; set; }
        public decimal TopMargin { get; set; }
        public decimal BottomMargin { get; set; }
        public decimal LeftMargin { get; set; }
        public decimal RightMargin { get; set; }
        public string Block1Location { get; set; }
        public decimal Block1Margin { get; set; }
        public string Block2Location { get; set; }
        public decimal Block2Margin { get; set; }
        public bool? IsEditable { get; set; }
        public bool? IsDeleteable { get; set; }
        public int UnitOfMeasure { get; set; }
        public decimal Block1Width { get; set; }
        public decimal Block1Height { get; set; }
        public decimal Block2Width { get; set; }
        public decimal Block2Height { get; set; }
        public decimal LabelWidth { get; set; }
        public decimal LabelHeight { get; set; }
        public decimal FontSize { get; set; }
        public string FontName { get; set; }
        public bool? IsBold { get; set; }
    }
}
