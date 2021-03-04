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
        /*
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
                        int success = service.CreateEmployee(model);
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
            return View(employee);
        }
        */
        // GET: Admin/Employees/Edit/5
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

        // POST: Admin/Employees/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "EmpNo,EmpName,EmpAccount,EmpPwd,EmpEmail,EmpSex,EmpBirth,EmpTel,HireDate,LeaveDate,EmpAccountState,ConfirmPassword,ChangePwd")] VW_Employee employee)
        {
            VW_Employee model = EncodeModel(employee);

            //不修改密碼
            if (!(employee.ChangePwd.HasValue && employee.ChangePwd.Value))
            {                               
                ModelState.Remove("EmpPwd");
                ModelState.Remove("ConfirmPassword");
            }

            if (ModelState.IsValid)
            {
                if (!(employee.ChangePwd.HasValue && employee.ChangePwd.Value))
                {
                    Employee tmpEmp = service.FindOne(m => m.EmpNo == employee.EmpNo);
                    if (tmpEmp == null)
                    {
                        return HttpNotFound();
                    }
                    model.EmpPwd = tmpEmp.EmpPwd;
                }
                else
                {
                    string hashPwd = UserManager.PasswordHasher.HashPassword(model.EmpPwd);
                    model.EmpPwd = hashPwd;
                }
                var user = await UserManager.FindByEmailAsync(model.EmpEmail);
                user.UserName = model.EmpName;
                user.PhoneNumber = model.EmpTel;
                user.PasswordHash = model.EmpPwd;
                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        int success = service.EditEmployee(model);
                        var result = await UserManager.UpdateAsync(user);
                        if (result.Succeeded)
                        {
                            scope.Complete();
                            return RedirectToAction("Index", "Employees", new { area = "Admin" });
                        }
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
            return View(employee);
        }

        // GET: Admin/Employees/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Employee employee = service.FindOne(m => m.EmpNo == id);
        //    if (employee == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(employee);
        //}

        // POST: Admin/Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Employee employee = service.FindOne(m => m.EmpNo == id);
            if (employee == null)
            {
                return Json("刪除失敗");
            }

            var user = await UserManager.FindByEmailAsync(employee.EmpEmail);
            var rolesForUser = await UserManager.GetRolesAsync(user.Id);

            var appDbContext = HttpContext.GetOwinContext().Get<ApplicationDbContext>();
            using (var transaction = appDbContext.Database.BeginTransaction())
            {
                try
                {
                    //foreach (var login in logins.ToList())
                    //{
                    //    await UserManager.RemoveLoginAsync(login.UserId, new UserLoginInfo(login.LoginProvider, login.ProviderKey));
                    //}
                    int success = service.DeleteEmployee(id);
                    if (success == 1)
                    {
                        if (rolesForUser.Count() > 0)
                        {
                            foreach (var item in rolesForUser.ToList())
                            {
                                // item should be the name of the role
                                var result = await UserManager.RemoveFromRoleAsync(user.Id, item);
                            }
                        }

                        await UserManager.DeleteAsync(user);

                        transaction.Commit();

                        return Json("刪除成功");
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    logger.Error(GetEntityErrorMsg(ex));
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    transaction.Rollback();
                }
                return Json("刪除失敗");
            }
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
