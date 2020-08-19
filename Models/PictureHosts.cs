using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class PictureHosts
    {
        public PictureHosts()
        {
            BusinessProfile = new HashSet<BusinessProfile>();
        }

        public int PictureHostId { get; set; }
        public string Name { get; set; }
        public string Ftpuserid { get; set; }
        public string Ftppassword { get; set; }
        public string RemoteFtphost { get; set; }
        public short RemoteFtpport { get; set; }
        public string HostUrl { get; set; }
        public string HostSubdir { get; set; }
        public bool HostRelative { get; set; }
        public bool Passive { get; set; }
        public byte ProtocolType { get; set; }

        public virtual ICollection<BusinessProfile> BusinessProfile { get; set; }
    }
}
