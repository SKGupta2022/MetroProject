using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class UserDetails
    {
        public int Pk_Id { get; set; }
        public string Subscription_Id { get; set; }
        public string CustCode { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Name must be 3 to 50 charecters")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter address")]
        [StringLength(maximumLength: 100)]
        public string Address { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please enter city")]
        [StringLength(maximumLength: 50)]
        public string City { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please enter state")]
        [StringLength(maximumLength: 50)]
        public string State { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please enter country")]
        [StringLength(maximumLength: 50)]
        public string Country { get; set; }

        [Display(Name = "Pincode")]
        [Required(ErrorMessage = "Please enter Pincode")]
        [StringLength(maximumLength: 6)]
        public string Pincode { get; set; }

        [Display(Name = "Mobile Number:")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Invalid Mobile Number.")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Mobile { get; set; }

        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Email is required.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "Invalid Email Address.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        //[Display(Name = "Password:")]
        //[Required(ErrorMessage = "Please enter password")]
        //[StringLength(maximumLength: 15, MinimumLength = 8, ErrorMessage = "Password must be 8 to 15 charecters")]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }

        //[Required(ErrorMessage = "Please enter confirm password")]
        //[Display(Name = "Confirm Password")]
        //[StringLength(maximumLength: 15, MinimumLength = 8, ErrorMessage = "Password must be 8 to 15 charecters")]
        //[Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        //public string ConfirmPassword { get; set; }
        public string BalanceAmt { get; set; }
        public List<PaymentDetails> RechargePaymentLst { get; set; }
        public string Response { get; set; }
        public string Message { get; set; }
        public CardDetails cardDetails { get; set; }
        public int SrNo { get; set; }
    }
}
