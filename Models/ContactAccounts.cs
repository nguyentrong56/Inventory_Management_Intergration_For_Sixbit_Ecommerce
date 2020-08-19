using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ContactAccounts
    {
        public ContactAccounts()
        {
            BusinessProfile = new HashSet<BusinessProfile>();
        }

        public int ContactAccountId { get; set; }
        public string Name { get; set; }
        public string RemoteMailHost { get; set; }
        public short RemoteMailPort { get; set; }
        public string ReplyToAddress { get; set; }
        public string Ccaddress { get; set; }
        public string Signature { get; set; }
        public string FromAddress { get; set; }
        public string Bccaddress { get; set; }
        public short EmailDelay { get; set; }
        public bool UseAuthentication { get; set; }
        public string AuthUserName { get; set; }
        public string AuthPassword { get; set; }
        public int EmailFormat { get; set; }
        public bool UseSsl { get; set; }
        public string SkypeId { get; set; }
        public bool ReturnReceipt { get; set; }

        public virtual ICollection<BusinessProfile> BusinessProfile { get; set; }
    }
}
