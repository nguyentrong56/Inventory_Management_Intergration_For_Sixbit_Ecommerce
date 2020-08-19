using System;
using System.Collections.Generic;

namespace BlueFox.Models
{
    public partial class PaymentServiceAccounts
    {
        public int PaymentServiceAccountId { get; set; }
        public string PaymentService { get; set; }
        public string Name { get; set; }
        public string AccountLogin { get; set; }
        public string Token { get; set; }
        public string SecretToken { get; set; }
        public string Signature { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
