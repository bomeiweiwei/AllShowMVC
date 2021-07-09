using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AllShowMVC.Models;
using AllShowMVC.Models.ViewModel;
using AllShowMVC.Service;

namespace AllShowMVC.Areas.Admin.Controllers
{
    public class ShopsController : Controller
    {
        readonly ShopService shopService;
        readonly EmployeeService employeeService;
        readonly ShClassService shClassService;
        public ShopsController()
        {
            shopService = new ShopService();
            employeeService = new EmployeeService();
            shClassService = new ShClassService();
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Shops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = shopService.FindOne(m => m.ShNo == id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }

        // GET: Admin/Shops/Create
        public ActionResult Create()
        {
            VW_Shop shop = new VW_Shop();
            var query= employeeService.GetAll().AsEnumerable().ToList();
            //ViewBag.EmpNo = new SelectList(query, "EmpNo", "EmpName");
            if (query != null)
            {
                shop.EmployeeDDL = query.Select(x => new SelectListItem()
                {
                    Text = x.EmpName,
                    Value = x.EmpNo.ToString()
                }).ToList();
                //shop.EmployeeDDL = new List<SelectListItem>();
            }
            else
            {
                shop.EmployeeDDL = new List<SelectListItem>();
            }

            var query2 = shClassService.GetAll().AsEnumerable().Select(
                    m => new ShClass
                    {
                        ShClassNo = m.ShClassNo,
                        ShClassName = m.ShClassName
                    }).ToList();
            //ViewBag.ShClassNo = new SelectList(query2, "ShClassNo", "ShClassName");
            if (query2 != null)
            {
                shop.ShClassDDL = query2.Select(x => new SelectListItem()
                {
                    Text = x.ShClassName,
                    Value = x.ShClassNo.ToString()
                }).ToList();
            }
            else
            {
                shop.ShClassDDL = new List<SelectListItem>();
            }

            return View(shop);
        }

        // GET: Admin/Shops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = shopService.FindOne(m => m.ShNo == id);
            if (shop == null)
            {
                return HttpNotFound();
            }

            var query = employeeService.GetAll().AsEnumerable().Select(
                m => new Employee
                {
                    EmpNo = m.EmpNo,
                    EmpName = m.EmpName
                }).ToList();
            ViewBag.EmpDDL = new SelectList(query, "EmpNo", "EmpName", shop.EmpNo);
            return View(shop);
        }       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                shopService.Dispose();
                employeeService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
