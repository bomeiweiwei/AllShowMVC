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
using AllShowMVC.Controllers;
using AllShowMVC.Models;
using AllShowMVC.Models.IdentityModel;
using AllShowMVC.Models.ViewModel;
using AllShowMVC.Service;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AllShowMVC.Areas.Admin.Controllers
{
    public class EmployeesController : BaseController
    {
        readonly EmployeeService service;
        public EmployeesController()
        {
            service = new EmployeeService();
        }
        // GET: Admin/Employees
        public ActionResult Index()
        {
            return View(service.GetAll().ToList());
        }

        // GET: Admin/Employees/Details/5
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

        // GET: Admin/Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Employees/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "EmpNo,EmpName,EmpAccount,EmpPwd,EmpEmail,EmpSex,EmpBirth,EmpTel,HireDate,LeaveDate,EmpAccountState,ConfirmPassword")] VW_Employee employee)
        {
            VW_Employee model = EncodeModel(employee);
            
            ModelState.Remove("EmpNo");
            ModelState.Remove("EmpAccount");
            if (ModelState.IsValid)
            {
                string hashPwd = UserManager.PasswordHasher.HashPassword(model.EmpPwd);

                model.EmpAccount = model.EmpEmail;
                model.EmpPwd = hashPwd;
                int success = service.CreateEmployee(model);
                if (success == 1)
                {
                    var user = new CustomUser
                    {
                        UserName = model.EmpName,
                        Email = model.EmpEmail,
                        PhoneNumber = model.EmpTel,
                        PasswordHash = hashPwd,
                        SecurityStamp = Guid.NewGuid().ToString()
                    };
                    using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                    {
                        try
                        {
                            var result = await UserManager.CreateAsync(user);
                            if (result.Succeeded)
                            {
                                //角色名稱
                                var roleName = "Admin";
                                //判斷角色是否存在
                                if (RoleManager.RoleExists(roleName) == false)
                                {
                                    //角色不存在,建立角色
                                    var role = new IdentityRole(roleName);
                                    await RoleManager.CreateAsync(role);
                                }
                                //將使用者加入該角色
                                await UserManager.AddToRoleAsync(user.Id, roleName);
                                scope.Complete();
                                return RedirectToAction("Index", "Employees", new { area = "Admin" });
                            }
                            AddErrors(result);
                        }
                        catch (DbEntityValidationException ex)
                        {
                            logger.Error(GetEntityErrorMsg(ex));
                        }
                        catch (Exception ex)
                        {
                            logger.Error(ex.Message);
                        }
                        finally
                        {
                            scope.Dispose();
                        }
                    }
                }
            }
            return View(employee);
        }

        // GET: Admin/Employees/Edit/5
        public ActionResult Edit(int? id)
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

        // POST: Admin/Employees/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpNo,EmpName,EmpAccount,EmpPwd,EmpEmail,EmpSex,EmpBirth,EmpTel,HireDate,LeaveDate,EmpAccountState")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                service.Update(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Admin/Employees/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: Admin/Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = service.FindOne(m => m.EmpNo == id);
            service.Delete(employee);
            return RedirectToAction("Index");
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
