using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Transactions;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using AllShowMVC.Infrastructure;
using AllShowMVC.Models;
using AllShowMVC.Models.IdentityModel;
using AllShowMVC.Models.Validate;
using AllShowMVC.Models.ViewModel;
using AllShowMVC.Service;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Newtonsoft.Json;

namespace AllShowMVC.Areas.WebApi.Controllers
{
    public class EmployeesController : BaseApiController
    {
        readonly EmployeeService service;
        public EmployeesController()
        {
            service = new EmployeeService();
        }

        // GET: api/Employees
        [System.Web.Http.HttpGet]
        public ApiReponse<List<Employee>> GetEmployee()
        {
            var result = service.GetAll().AsEnumerable().Select(
                m => new Employee
                {
                    EmpNo = m.EmpNo,
                    EmpEmail = m.EmpEmail,
                    EmpName = m.EmpName,
                    EmpBirth = m.EmpBirth,
                    EmpTel = m.EmpTel
                }).ToList();
            return new ApiReponse<List<Employee>>(result);
        }

        // GET: api/Employees/5
        [System.Web.Http.HttpGet]
        [ResponseType(typeof(Employee))]
        public IHttpActionResult GetEmployee(int id)
        {
            Employee employee = service.FindOne(m => m.EmpNo == id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        [System.Web.Http.HttpPut]
        [ValidateAntiForgeryToken]
        [ResponseType(typeof(void))]
        public async System.Threading.Tasks.Task<IHttpActionResult> PutEmployee(int id, VW_Employee employee)
        {
            VW_Employee model = EncodeModel(employee);

            //不修改密碼
            if (!(employee.ChangePwd.HasValue && employee.ChangePwd.Value))
            {
                ModelState.Remove("employee.EmpPwd");
                ModelState.Remove("employee.ConfirmPassword");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.EmpNo)
            {
                return BadRequest();
            }

            if (!(employee.ChangePwd.HasValue && employee.ChangePwd.Value))
            {
                Employee tmpEmp = service.FindOne(m => m.EmpNo == employee.EmpNo);
                if (tmpEmp == null)
                {
                    return NotFound();
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
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    logger.Error(GetEntityErrorMsg(ex));
                    return BadRequest("更新失敗");
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    return BadRequest("更新失敗");
                }
                finally
                {
                    scope.Dispose();
                }
            }

            return Content(HttpStatusCode.OK, model);
        }

        // POST: api/Employees
        [System.Web.Http.HttpPost]
        [ValidateAntiForgeryToken]
        [ResponseType(typeof(VW_Employee))]
        public async System.Threading.Tasks.Task<IHttpActionResult> PostEmployee(VW_Employee employee)
        {
            VW_Employee model = EncodeModel(employee);

            ModelState.Remove("employee.EmpNo");
            ModelState.Remove("employee.EmpAccount");

            if (!ModelState.IsValid)
            {
                //var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                var errorList = new List<ValidateObj>();
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var value = ModelState[modelStateKey];
                    string msg = "";
                    foreach (var error in value.Errors)
                    {
                        msg += error.ErrorMessage + " ";
                    }
                    //ModelState.AddModelError(modelStateKey, msg);
                    errorList.Add(
                        new ValidateObj
                        {
                            ValidateFiled = modelStateKey.Replace("employee.", ""),
                            ValidateMessage = msg
                        });
                }
                //foreach (var e in errorList)
                //{
                //    ModelState.AddModelError(e.ValidateFiled, e.ValidateMessage);
                //}
                var ModelStateErrors = ModelState.Where(x => x.Value.Errors.Count > 0)
                    .ToDictionary(k => k.Key, k => k.Value.Errors.Select(e => e.ErrorMessage).ToArray());
                string message = JsonConvert.SerializeObject(errorList);
                return BadRequest(message);
            }

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
                    }
                    AddErrors(result);
                }
                catch (DbEntityValidationException ex)
                {
                    logger.Error(GetEntityErrorMsg(ex));
                    return BadRequest("新增失敗");
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    return BadRequest("新增失敗");
                }
                finally
                {
                    scope.Dispose();
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = model.EmpNo }, model);
        }

        // DELETE: api/Employees/5
        [System.Web.Http.HttpDelete]
        [ResponseType(typeof(Employee))]
        public async System.Threading.Tasks.Task<IHttpActionResult> DeleteEmployee(int id)
        {
            Employee employee = service.FindOne(m => m.EmpNo == id);
            if (employee == null)
            {
                return NotFound();
            }

            var user = await UserManager.FindByEmailAsync(employee.EmpEmail);
            var rolesForUser = await UserManager.GetRolesAsync(user.Id);

            var appDbContext = HttpContext.Current.GetOwinContext().Get<ApplicationDbContext>();
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

                return Ok(employee);
            }
        }
    }
}