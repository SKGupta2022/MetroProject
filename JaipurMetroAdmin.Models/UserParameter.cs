using System;
using System.Collections.Generic;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class UserParameter
    {
        public string CustCode { get; set; }
        public string UserMobile { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string Amount { get; set; }
        public string Purpose { get; set; }
        public Adddress address { get; set; }
        public RechargeDetails rechargeDetails { get; set; }
    }
}
