using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class CardDetails
    {
        public string CustId { get; set; }
        [Display(Name = "Enter Mobile No")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Invalid Mobile Number.")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Mobile { get; set; }

        [Display(Name = "Enter Card No")]
        [Required(ErrorMessage = "Please enter card number")]
        [StringLength(maximumLength: 15, MinimumLength = 8, ErrorMessage = "Card number must be 8 to 15 charecters")]
        public string CardNo { get; set; }
        [Required(ErrorMessage = "Please enter retype card number")]
        [Display(Name = "Enter Retype Card No")]
        [StringLength(maximumLength: 15, MinimumLength = 8, ErrorMessage = "Card number must be 8 to 15 charecters")]
        [Compare("CardNo", ErrorMessage = "Retype card number does not match")]
        public string RetypeCardNo { get; set; }
        public string PendingAmt { get; set; }
        public DateTime DueDate { get; set; }
        public int TotalRechargeAmt { get; set; }
        public int TotalRechargeExpenses { get; set; }
    }
}
