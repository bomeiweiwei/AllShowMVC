using AllShowMVC.Resource.App_GlobalResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AllShowMVC.Models.ViewModel
{
    public class VW_Authority
    {
        public int EmpNo { get; set; }
        public int AuthorityNo { get; set; }
        public string EmpName { get; set; }
        public string AuthorityName { get; set; }
        public string Note { get; set; }

        public List<SelectListItem> AuthorityFunDDL { get; set; }
        public List<SelectListItem> EmpDDL { get; set; }
    }
}
