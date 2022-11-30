using System;
using System.Collections.Generic;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class PaymentDetails
    {
        public string Mobile { get; set; }
        public string RechargeId { get; set; }
        public DateTime RechargeDate { get; set; }
        public DateTime ExpiryFrom { get; set; }
        public DateTime ExpiryTo { get; set; }
        public int Amount { get; set; }
        public string PaymentMode { get; set; }
        public string RechargeStatus { get; set; }
    }
}
