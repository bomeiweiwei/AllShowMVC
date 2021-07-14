using AllShowMVC.App_Class.Base;
using AllShowMVC.Models;
using AllShowMVC.Models.ViewModel;
using AllShowMVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AllShowMVC.Areas.Admin.Controllers
{
    public class AuthorityController : BaseController
    {
        readonly AuthorityService service;
        readonly EmployeeService employeeService;
        readonly AuthorityFunctionService authorityFunctionService;
        public AuthorityController()
        {
            service = new AuthorityService();
            employeeService = new EmployeeService();
            authorityFunctionService = new AuthorityFunctionService();
        }
        // GET: Admin/Authority
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int? EmpNo, int? AuthorityNo)
        {
            if (EmpNo == null || AuthorityNo==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Authority authority = service.FindOne(m => m.EmpNo == EmpNo && m.AuthorityNo== AuthorityNo);
            if (authority == null)
            {
                return HttpNotFound();
            }
            VW_Authority result = new VW_Authority
            {
                EmpNo = authority.EmpNo,
                AuthorityNo = authority.AuthorityNo,
                EmpName = authority.Employee.EmpName,
                AuthorityName = authority.AuthorityFunction.AuthorityName,
                Note = authority.Note
            };
            return View(result);
        }

        public ActionResult Create()
        {
            VW_Authority authority = new VW_Authority();
            var query= employeeService.GetAll().OrderBy(m => m.EmpNo).AsEnumerable().ToList();
            if (query != null)
            {
                authority.EmpDDL = query.Select(x => new SelectListItem()
                {
                    Text = x.EmpName,
                    Value = x.EmpNo.ToString()
                }).ToList();
                //shop.EmployeeDDL = new List<SelectListItem>();
            }
            else
            {
                authority.EmpDDL = new List<SelectListItem>();
            }
            authority.EmpDDL.Insert(0, new SelectListItem { Text = "請選擇", Value = "" });
            var query2 = authorityFunctionService.GetAll().OrderBy(m => m.AuthorityNo).AsEnumerable().Select(
                    m => new AuthorityFunction
                    {
                        AuthorityNo = m.AuthorityNo,
                        AuthorityName = m.AuthorityName
                    }).ToList();
            //ViewBag.ShClassNo = new SelectList(query2, "ShClassNo", "ShClassName");
            if (query2 != null)
            {
                authority.AuthorityFunDDL = query2.Select(x => new SelectListItem()
                {
                    Text = x.AuthorityName,
                    Value = x.AuthorityNo.ToString()
                }).ToList();
            }
            else
            {
                authority.AuthorityFunDDL = new List<SelectListItem>();
            }
            authority.AuthorityFunDDL.Insert(0, new SelectListItem { Text = "請選擇", Value = "" });

            return View(authority);
        }

        public ActionResult Edit(int? EmpNo, int? AuthorityNo)
        {
            if (EmpNo == null || AuthorityNo == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Authority authority = service.FindOne(m => m.EmpNo == EmpNo && m.AuthorityNo == AuthorityNo);
            if (authority == null)
            {
                return HttpNotFound();
            }
            VW_Authority result = new VW_Authority
            {
                EmpNo = authority.EmpNo,
                AuthorityNo = authority.AuthorityNo,
                EmpName = authority.Employee.EmpName,
                AuthorityName = authority.AuthorityFunction.AuthorityName,
                Note = authority.Note
            };
            return View(result);
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