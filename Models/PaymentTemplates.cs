using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class PaymentTemplates
    {
        public PaymentTemplates()
        {
            ItemsBidstart = new HashSet<ItemsBidstart>();
            ItemsEbay = new HashSet<ItemsEbay>();
            ItemsMercado = new HashSet<ItemsMercado>();
            Listings = new HashSet<Listings>();
        }

        public int PaymentTemplateId { get; set; }
        public string Name { get; set; }
        public bool MoneyOrder { get; set; }
        public bool PersonalCheck { get; set; }
        public bool VisaMc { get; set; }
        public bool AmEx { get; set; }
        public bool Discover { get; set; }
        public bool OtherPay { get; set; }
        public bool PayPalAccepted { get; set; }
        public string PayPalEmail { get; set; }
        public bool ImmediatePay { get; set; }
        public string PaymentInstructions { get; set; }
        public bool ReturnsAccepted { get; set; }
        public string ReturnWithin { get; set; }
        public string RefundPolicy { get; set; }
        public int DepositType { get; set; }
        public decimal DepositAmount { get; set; }
        public string ReturnPolicy { get; set; }
        public bool BankDeposit { get; set; }
        public bool ShowBankAccount { get; set; }
        public bool Ccother { get; set; }
        public bool Cod { get; set; }
        public bool Escrow { get; set; }
        public int OrdinalId { get; set; }
        public int HoursToDeposit { get; set; }
        public bool ProPay { get; set; }
        public bool PayOnPickup { get; set; }
        public string ReturnPaidBy { get; set; }
        public bool Moneybookers { get; set; }
        public bool Paymate { get; set; }
        public bool WesternUnion { get; set; }
        public string MoneybookersEmail { get; set; }
        public bool GoogleCheckoutAccepted { get; set; }
        public string GoogleCheckoutId { get; set; }
        public string GoogleCheckoutKey { get; set; }
        public int RestockingFee { get; set; }
        public bool MercadoPagoAccepted { get; set; }
        public string NonMercadoPayment { get; set; }
        public bool ExtendedHolidayReturns { get; set; }
        public bool InternationalReturnsAccepted { get; set; }
        public string InternationalReturnWithin { get; set; }
        public string InternationalRefundPolicy { get; set; }
        public string InternationalReturnPaidBy { get; set; }

        public virtual ICollection<ItemsBidstart> ItemsBidstart { get; set; }
        public virtual ICollection<ItemsEbay> ItemsEbay { get; set; }
        public virtual ICollection<ItemsMercado> ItemsMercado { get; set; }
        public virtual ICollection<Listings> Listings { get; set; }
    }
}
