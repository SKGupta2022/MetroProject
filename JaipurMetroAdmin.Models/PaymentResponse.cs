using System;
using System.Collections.Generic;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class PaymentResponse
    {
        public ResponseParameters RESPONSEPARAMETERS { get; set; }
        public string RESPONSEJSON { get; set; }
        public string STATUS { get; set; }
        public string ENCDATA { get; set; }
        public bool CHECKSUMVALID { get; set; }
        public string ResponseParameterJson { get; set; }

    }
}
