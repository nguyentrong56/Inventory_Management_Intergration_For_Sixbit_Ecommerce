using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Settings
    {
        public int SettingId { get; set; }
        public string SiteIds { get; set; }
        public string ApplicationVersion { get; set; }
        public short CategoryVersionEbayUs { get; set; }
        public short DurationSetVersionEbayUs { get; set; }
        public DateTime? LastAccessedDate { get; set; }
        public string RegisteredEmail { get; set; }
        public string AutoFeedbackMsg { get; set; }
        public string LicenseKey { get; set; }
        public string Options { get; set; }
        public string AccCheck { get; set; }
        public string Express1AccountId { get; set; }
        public string Express1Passphrase { get; set; }
        public string EndiciaAccountId { get; set; }
        public string EndiciaPassphrase { get; set; }
        public string DomainLookup { get; set; }
        public DateTime? DomainLookupUpdateDate { get; set; }
        public string Cfdefinition { get; set; }
        public string DatabaseUuid { get; set; }
        public string EbayApplicationAccessToken { get; set; }
        public DateTime? EbayApplicationAccessTokenExpireDate { get; set; }
    }
}
