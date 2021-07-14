using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AllShowMVC.Models.ViewModel
{
    public class VW_Shop : Shop
    {
        public string EmpName { get; set; }
        public string ShClassName { get; set; }
        public List<SelectListItem> EmployeeDDL { get; set; }
        public List<SelectListItem> ShClassDDL { get; set; }
    }
}
