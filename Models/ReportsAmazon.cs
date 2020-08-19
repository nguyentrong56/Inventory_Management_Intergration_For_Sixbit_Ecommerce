using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ReportsAmazon
    {
        public decimal ReportRequestId { get; set; }
        public int ReportType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Scheduled { get; set; }
        public DateTime SubmittedDate { get; set; }
        public int StatusId { get; set; }
        public string GeneratedReportId { get; set; }
        public DateTime? StartedProcessingDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public bool CreateNewItems { get; set; }
    }
}
