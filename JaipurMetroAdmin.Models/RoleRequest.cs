using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class RoleRequest
    {
        [Display(Name = "Role Name")]
        [Required(ErrorMessage = "Please enter role name")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Role Name must be 3 to 50 charecters")]
        public string RoleName { get; set; }
        public string CreatedBy { get; set; }
    }
}
