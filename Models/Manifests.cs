using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class Manifests
    {
        public Manifests()
        {
            ShipmentsScanFormManifest = new HashSet<Shipments>();
            ShipmentsUspspickupManifest = new HashSet<Shipments>();
        }

        public int ManifestId { get; set; }
        public byte ManifestType { get; set; }
        public DateTime? GenerationDate { get; set; }
        public byte[] ManifestImage { get; set; }
        public string ConfirmationNumber { get; set; }
        public string CarrierType { get; set; }

        public virtual ICollection<Shipments> ShipmentsScanFormManifest { get; set; }
        public virtual ICollection<Shipments> ShipmentsUspspickupManifest { get; set; }
    }
}
