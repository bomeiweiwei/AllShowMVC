using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using AllShowMVC.App_Class.Base;
using AllShowMVC.Models;
using AllShowMVC.Models.IdentityModel;
using AllShowMVC.Models.ViewModel;
using AllShowMVC.Service;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace AllShowMVC.Areas.Admin.Controllers
{
    public class EmployeesController : BaseController
    {
        readonly EmployeeService service;
        public EmployeesController()
        {
            service = new EmployeeService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = service.FindOne(m => m.EmpNo == id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VW_Employee employee = service.GetEmployee(id.Value);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                service.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
