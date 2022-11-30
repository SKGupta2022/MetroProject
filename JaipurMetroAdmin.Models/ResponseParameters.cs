using System;
using System.Collections.Generic;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class ResponseParameters
    {
        public string MERCHANTCODE { get; set; }
        public string REQTIMESTAMP { get; set; }
        public string PRN { get; set; }
        public decimal? AMOUNT { get; set; }
        public string RPPTXNID { get; set; }
        public string RPPTIMESTAMP { get; set; }
        public string PAYMENTAMOUNT { get; set; }
        public string STATUS { get; set; }
        public string PAYMENTMODE { get; set; }
        public string PAYMENTMODEBID { get; set; }
        public string PAYMENTMODETIMESTAMP { get; set; }
        public string RESPONSECODE { get; set; }
        public string RESPONSEMESSAGE { get; set; }
        public string UDF1 { get; set; }
        public string UDF2 { get; set; }
        public string UDF3 { get; set; }
        public string CHECKSUM { get; set; }
    }
}
