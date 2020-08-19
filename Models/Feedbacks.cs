using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Feedbacks
    {
        public int FeedbackId { get; set; }
        public string Feedback { get; set; }
        public byte Type { get; set; }
        public int OrdinalId { get; set; }
    }
}
