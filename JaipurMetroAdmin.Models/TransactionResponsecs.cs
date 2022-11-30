using System;
using System.Collections.Generic;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class TransactionResponse
    {
        public int TransactionId { get; set; }
        public int CustId { get; set; }
        public string TransResponse { get; set; }
        public int AlertType { get; set; }
    }
}
