using AllShowMVC.App_Class.Base;
using AllShowMVC.Infrastructure;
using AllShowMVC.Models;
using AllShowMVC.Models.Validate;
using AllShowMVC.Models.ViewModel;
using AllShowMVC.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using AllShowMVC.Resource.App_GlobalResources;

namespace AllShowMVC.Areas.WebApi.Controllers
{
    public class AuthorityController : BaseApiController
    {
        readonly AuthorityService service;
        //readonly EmployeeService employeeService;
        //readonly AuthorityFunctionService authorityFunctionService;
        public AuthorityController()
        {
            service = new AuthorityService();
            //employeeService = new EmployeeService();
            //authorityFunctionService = new AuthorityFunctionService();
        }

        // GET: api/Employees
        [System.Web.Http.HttpGet]
        public ApiReponse<List<VW_Authority>> GetAuthority()
        {
            var result = service.GetAll().OrderBy(m => m.EmpNo).AsEnumerable().Select(
                m => new VW_Authority
                {
                    EmpNo = m.EmpNo,
                    AuthorityNo = m.AuthorityNo,
                    EmpName = m.Employee.EmpName,
                    AuthorityName = m.AuthorityFunction.AuthorityName,
                    Note = m.Note
                }).ToList();
            return new ApiReponse<List<VW_Authority>>(result);
        }

        // GET: api/Employees/5
        [System.Web.Http.HttpGet]
        [ResponseType(typeof(VW_Authority))]
        public IHttpActionResult GetAuthority(int EmpNo, int AuthorityNo)
        {
            Authority authority = service.FindOne(m => m.EmpNo == EmpNo && m.AuthorityNo == AuthorityNo);
            if (authority == null)
            {
                return NotFound();
            }
            VW_Authority result = new VW_Authority
            {
                EmpNo = authority.EmpNo,
                AuthorityNo = authority.AuthorityNo,
                EmpName = authority.Employee.EmpName,
                AuthorityName = authority.AuthorityFunction.AuthorityName,
                Note = authority.Note
            };
            return Ok(result);
        }

        // PUT: api/Employees/5
        [System.Web.Http.HttpPut]
        [ValidateAntiForgeryToken]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAuthority(int EmpNo, int AuthorityNo, VW_Authority authority)
        {
            VW_Authority _authority = EncodeModel(authority);

            if (EmpNo != _authority.EmpNo && AuthorityNo != _authority.AuthorityNo)
            {
                return BadRequest();
            }
            Authority searchModel = service.FindOne(m => m.EmpNo == _authority.EmpNo && m.AuthorityNo == _authority.AuthorityNo);
            if (searchModel != null)
            {
                searchModel.Note = _authority.Note;
                service.Update(searchModel);
            }
            else
            {
                return BadRequest();
            }

            return Content(HttpStatusCode.OK, _authority);
        }

        /// <summary>
        /// 新增權限
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [System.Web.Http.HttpPost]
        [ValidateAntiForgeryToken]
        [ResponseType(typeof(VW_Authority))]
        public IHttpActionResult PostAuthority(VW_Authority model)
        {
            ExecuteResult executeResult = new ExecuteResult();

            string objDeclaredName = nameof(model);
            VW_Authority _model = EncodeModel(model);

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

                //var ModelStateErrors = ModelState.Where(x => x.Value.Errors.Count > 0)
                //    .ToDictionary(k => k.Key, k => k.Value.Errors.Select(e => e.ErrorMessage).ToArray());
                string message = JsonConvert.SerializeObject(errorList);

                executeResult.Code = ((int)Code.ModelValid).ToString();
                executeResult.Message = message;
                string result= JsonConvert.SerializeObject(executeResult);
                return BadRequest(result);
            }

            Authority auth = new Authority { EmpNo = _model.EmpNo, AuthorityNo = _model.AuthorityNo, Note = _model.Note };
            try
            {
                int result = service.Create(auth);
                if (result == 1)
                    return CreatedAtRoute("DefaultApi", new { _model.EmpNo, _model.AuthorityNo }, _model);
                else
                    return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [System.Web.Http.HttpDelete]
        [ResponseType(typeof(Authority))]
        public IHttpActionResult DeleteAuthority(int EmpNo, int AuthorityNo)
        {
            try
            {
                Authority searchModel = service.FindOne(m => m.EmpNo == EmpNo && m.AuthorityNo == AuthorityNo);
                if (searchModel != null)
                {
                    service.Delete(searchModel);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
            return Ok();
        }
    }

}
