using System;
using System.Collections.Generic;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class UserModel
    {
        public string UserMobile { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public int Amount { get; set; }
        public string Purpose { get; set; }
        public Adddress address { get; set; }
        public RechargeDetails rechargeDetails { get; set; }
    }

    public class Adddress
    {
        public string fullAddress { get; set; }
        public string City { get; set; }
        public string Distict { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
    }

    public class RechargeDetails
    {
        public string CardNo { get; set; }
        public string Recharge { get; set; }
        public string Invoice { get; set; }
        public DateTime Invoice_Date { get; set; }

    }
}
