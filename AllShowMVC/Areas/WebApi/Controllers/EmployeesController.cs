﻿using System;
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
using AllShowMVC.App_Class.Base;
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
        public async System.Threading.Tasks.Task<IHttpActionResult> PutEmployee(int id, VW_Employee model)
        {
            ExecuteResult executeResult = new ExecuteResult();

            string objDeclaredName = nameof(model);
            VW_Employee _model = EncodeModel(model);

            //不修改密碼
            if (!(_model.ChangePwd.HasValue && _model.ChangePwd.Value))
            {
                ModelState.Remove($"{objDeclaredName}.EmpPwd");
                ModelState.Remove($"{objDeclaredName}.ConfirmPassword");
            }
            if (!ModelState.IsValid)
            {
                var errorList = new List<ValidateObj>();
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var value = ModelState[modelStateKey];
                    string msg = "";
                    foreach (var error in value.Errors)
                    {
                        msg += error.ErrorMessage + " ";
                    }
                    string ignore = objDeclaredName + ".";
                    string column = modelStateKey.Replace(ignore, "");
                    errorList.Add(
                        new ValidateObj
                        {
                            ValidateFiled = column,
                            ValidateMessage = msg
                        });
                }

                string message = JsonConvert.SerializeObject(errorList);

                executeResult.Code = ((int)Code.ModelValid).ToString();
                executeResult.Message = message;
                string result = JsonConvert.SerializeObject(executeResult);
                return BadRequest(result);
            }

            if (id != _model.EmpNo)
            {
                return BadRequest();
            }

            if (!(_model.ChangePwd.HasValue && _model.ChangePwd.Value))
            {
                Employee tmpEmp = service.FindOne(m => m.EmpNo == _model.EmpNo);
                if (tmpEmp == null)
                {
                    return NotFound();
                }
                _model.EmpPwd = tmpEmp.EmpPwd;
            }
            else
            {
                string hashPwd = UserManager.PasswordHasher.HashPassword(_model.EmpPwd);
                _model.EmpPwd = hashPwd;
            }
            var user = await UserManager.FindByEmailAsync(_model.EmpEmail);
            user.UserName = _model.EmpName;
            user.PhoneNumber = _model.EmpTel;
            user.PasswordHash = _model.EmpPwd;
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    int success = service.EditEmployee(_model);
                    var result = await UserManager.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        scope.Complete();
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    logger.Error(GetEntityErrorMsg(ex));
                    return BadRequest();
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    return BadRequest();
                }
                finally
                {
                    scope.Dispose();
                }
            }

            return Content(HttpStatusCode.OK, _model);
        }

        // POST: api/Employees
        [System.Web.Http.HttpPost]
        [ValidateAntiForgeryToken]
        [ResponseType(typeof(VW_Employee))]
        public async System.Threading.Tasks.Task<IHttpActionResult> PostEmployee(VW_Employee model)
        {
            ExecuteResult executeResult = new ExecuteResult();

            string objDeclaredName = nameof(model);
            VW_Employee _model = EncodeModel(model);

            ModelState.Remove($"{objDeclaredName}.EmpNo");
            ModelState.Remove($"{objDeclaredName}.EmpAccount");

            if (!ModelState.IsValid)
            {
                var errorList = new List<ValidateObj>();
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var value = ModelState[modelStateKey];
                    string msg = "";
                    foreach (var error in value.Errors)
                    {
                        msg += error.ErrorMessage + " ";
                    }
                    string ignore = $"{objDeclaredName}.";
                    string column = modelStateKey.Replace(ignore, "");
                    errorList.Add(
                        new ValidateObj
                        {
                            ValidateFiled = column,
                            ValidateMessage = msg
                        });
                }

                string message = JsonConvert.SerializeObject(errorList);

                executeResult.Code = ((int)Code.ModelValid).ToString();
                executeResult.Message = message;
                string result = JsonConvert.SerializeObject(executeResult);
                return BadRequest(result);
            }

            string hashPwd = UserManager.PasswordHasher.HashPassword(_model.EmpPwd);

            _model.EmpAccount = _model.EmpEmail;
            _model.EmpPwd = hashPwd;

            var user = new CustomUser
            {
                UserName = _model.EmpName,
                Email = _model.EmpEmail,
                PhoneNumber = _model.EmpTel,
                PasswordHash = hashPwd,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    int success = service.CreateEmployee(_model);
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
                    return BadRequest();
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    return BadRequest();
                }
                finally
                {
                    scope.Dispose();
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = _model.EmpNo }, _model);
        }

        // DELETE: api/Employees/5
        [System.Web.Http.HttpDelete]
        [ResponseType(typeof(Employee))]
        public async System.Threading.Tasks.Task<IHttpActionResult> DeleteEmployee(int id)
        {
            bool deleteSuccess = false;
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
                        deleteSuccess = true;
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

                if (deleteSuccess)
                    return Ok(employee);
                else
                    return BadRequest();
            }
        }
    }
}