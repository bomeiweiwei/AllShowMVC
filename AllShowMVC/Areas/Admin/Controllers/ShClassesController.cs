using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AllShowMVC.App_Class.Base;
using AllShowMVC.Models;
using AllShowMVC.Service;

namespace AllShowMVC.Areas.Admin.Controllers
{
    public class ShClassesController : BaseController
    {
        readonly ShClassService service;
        public ShClassesController()
        {
            service = new ShClassService();
        }

        // GET: Admin/ShClasses
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/ShClasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShClass shClass = service.FindOne(m => m.ShClassNo == id);
            if (shClass == null)
            {
                return HttpNotFound();
            }
            return View(shClass);
        }

        // GET: Admin/ShClasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Admin/ShClasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShClass shClass = service.FindOne(m => m.ShClassNo == id);
            if (shClass == null)
            {
                return HttpNotFound();
            }
            return View(shClass);
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
