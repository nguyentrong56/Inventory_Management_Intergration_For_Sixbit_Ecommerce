using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class ConsignmentPlans
    {
        public int ConsignmentPlanId { get; set; }
        public string Name { get; set; }
        public int OrdinalId { get; set; }
        public decimal FlatCommission { get; set; }
        public string CommissionScale { get; set; }
        public bool IsGraduated { get; set; }
        public byte CommissionType { get; set; }
        public decimal MaxCommission { get; set; }
        public decimal MinCommission { get; set; }
        public decimal OtherCommFees { get; set; }
        public byte ListingFeeType { get; set; }
        public decimal BaseConsignmentFee { get; set; }
        public bool IsBaseFeeCollectedPrior { get; set; }
        public bool? IncludeFeesInCommission { get; set; }
        public bool IsProfitSharing { get; set; }
        public decimal ConsignorSharePercent { get; set; }
        public bool IsFvfcharged { get; set; }
        public bool IsOtherFeeCharged { get; set; }
        public bool IsPpcharged { get; set; }
        public bool? ProfitSharingConsigneePaidFees { get; set; }
        public bool? ProfitSharingConsignorPaidForItem { get; set; }
        public bool ApplyCommissionToIndividualItems { get; set; }
        public bool IsShippingCharged { get; set; }
    }
}
