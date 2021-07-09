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
        public List<SelectListItem> EmployeeDDL { get; set; }
        public List<SelectListItem> ShClassDDL { get; set; }
    }
}
