using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class LoginModel
    {
        [Display(Name = "Mobile")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Invalid Mobile Number.")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Mobile { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(maximumLength: 15, MinimumLength = 8, ErrorMessage = "Password must be 8 to 15 charecters")]
        public string Passwrd { get; set; }

        public string RechargeId { get; set; }

    }
}
