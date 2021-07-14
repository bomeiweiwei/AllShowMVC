using AllShowMVC.Common;
using AllShowMVC.Resource.App_GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllShowMVC.Models.ViewModel
{
    public class VW_Employee : Employee
    {
        [EmailAddress]
        [ResourceTool.LocalizedDisplayName("EmpEmail", typeof(AllShowResource))]
        [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
        [MaxLength(256, ErrorMessageResourceName = "Field_MaxLength", ErrorMessageResourceType = typeof(AllShowResource))]
        public new string EmpEmail { get; set; }

        [DataType(DataType.Password)]
        [ResourceTool.LocalizedDisplayName("EmpPwd", typeof(AllShowResource))]
        [Required(ErrorMessageResourceName = "Field_Required", ErrorMessageResourceType = typeof(AllShowResource))]
        public new string EmpPwd { get; set; }

        [DataType(DataType.Password)]
        [ResourceTool.LocalizedDisplayName("ConfirmPassword", typeof(AllShowResource))]
        [Compare("EmpPwd", ErrorMessageResourceName = "ConfirmPasswordMsg", ErrorMessageResourceType = typeof(AllShowResource))]
        public string ConfirmPassword { get; set; }

        public bool? ChangePwd { get; set; }
    }
}
