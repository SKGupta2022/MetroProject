using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JaipurMetroAdmin.Models
{
    public class ModuleRequest
    {
        [Display(Name = "Module Name")]
        [Required(ErrorMessage = "Module Name is required.")]
        [StringLength(maximumLength: 50, MinimumLength =3, ErrorMessage = "Please enter module name have lenth between 3 to 50 charecters")]
        public string ModuleNm { get; set; }
        [Display(Name = "Module Description")]
        public string ModuleDesc { get; set; }
        public bool IsChild { get; set; }
        public int IsParentModuleId { get; set; }
    }

    public class ModuleResponse
    {
        public string ModuleNm { get; set; }
        public string ModuleDesc { get; set; }
        public int IsParentModuleId { get; set; }
        public string ParentModuleNm { get; set; }
        public int SrNo { get; set; }
    }
}
