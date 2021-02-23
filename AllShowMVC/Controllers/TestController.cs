using AllShowMVC.Models;
using AllShowMVC.Resource;
using AllShowMVC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllShowMVC.Controllers
{
    public class TestController : Controller
    {
        readonly TestService testService;
        MemberService memberService;
        public TestController()
        {
            //testService = new TestService();
            memberService = new MemberService();
        }
        // GET: Test
        public ActionResult Index()
        {
            //var query = testService.GetMembers();
            var query = memberService.GetMembers();
            return View(query);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            ModelState.Remove("MemNo");
            if (ModelState.IsValid)
            {               
                return RedirectToAction("Index");
            }
            return View(member);
        }

        public ActionResult SetCulture(string culture, string returnUrl)
        {
            // Validate input 
            culture = CultureHelper.GetImplementedCulture(culture);

            // Save culture in a cookie 
            HttpCookie cookie = Request.Cookies["_culture"];

            if (cookie != null)
            {
                // update cookie value 
                cookie.Value = culture;
            }
            else
            {
                // create cookie value 
                cookie = new HttpCookie("_culture");
                cookie.Value = culture;
                cookie.Expires = DateTime.Now.AddYears(1);
            }

            Response.Cookies.Add(cookie);
            return Redirect(returnUrl);
        }
    }
}