using System;
using System.Collections.Generic;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class RechargeModel
    {
        public string CustId { get; set; }
        public string CardNo { get; set; }
        public string Mobile { get; set; }
        public string Recharge { get; set; }
        public DateTime ExpiryFrom { get; set; }
        public DateTime ExpiryTo { get; set; }
        public int PaymentAmt { get; set; }
        public string PaymentMode { get; set; }
        public PaymentResponse PaymentTransDetails { get; set; }
    }
}
