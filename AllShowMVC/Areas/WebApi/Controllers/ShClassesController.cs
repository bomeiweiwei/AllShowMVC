using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using AllShowMVC.App_Class.Base;
using AllShowMVC.Infrastructure;
using AllShowMVC.Models;
using AllShowMVC.Models.Validate;
using AllShowMVC.Resource.App_GlobalResources;
using AllShowMVC.Service;
using Newtonsoft.Json;

namespace AllShowMVC.Areas.WebApi.Controllers
{
    public class ShClassesController : BaseApiController
    {
        readonly ShClassService service;
        public ShClassesController()
        {
            service = new ShClassService();
        }

        // GET: api/ShClasses
        [System.Web.Http.HttpGet]
        public ApiReponse<List<ShClass>> GetShClass()
        {
            var result = service.GetAll().AsEnumerable().Select(
                m => new ShClass
                {
                    ShClassNo = m.ShClassNo,
                    ShClassName = m.ShClassName
                }).ToList();
            return new ApiReponse<List<ShClass>>(result);
        }

        // GET: api/ShClasses/5
        [System.Web.Http.HttpGet]
        [ResponseType(typeof(ShClass))]
        public IHttpActionResult GetShClass(int id)
        {
            ShClass shClass = service.FindOne(m => m.ShClassNo == id);
            if (shClass == null)
            {
                return NotFound();
            }

            return Ok(shClass);
        }

        // PUT: api/ShClasses/5
        [System.Web.Http.HttpPut]
        [ValidateAntiForgeryToken]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutShClass(int id, ShClass model)
        {
            ExecuteResult executeResult = new ExecuteResult();

            string objDeclaredName = nameof(model);
            ShClass _model = EncodeModel(model);

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

                //var ModelStateErrors = ModelState.Where(x => x.Value.Errors.Count > 0)
                //    .ToDictionary(k => k.Key, k => k.Value.Errors.Select(e => e.ErrorMessage).ToArray());
                string message = JsonConvert.SerializeObject(errorList);

                executeResult.Code = ((int)Code.ModelValid).ToString();
                executeResult.Message = message;
                string result = JsonConvert.SerializeObject(executeResult);
                return BadRequest(result);
            }

            if (id != _model.ShClassNo)
            {
                return BadRequest();
            }

            try
            {
                int result = service.Update(_model);
                if (result != 1)
                    return BadRequest();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                logger.Error(ex.Message);
                return BadRequest();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return BadRequest();
            }

            return Content(HttpStatusCode.OK, _model);
        }

        // POST: api/ShClasses
        [System.Web.Http.HttpPost]
        [ValidateAntiForgeryToken]
        [ResponseType(typeof(ShClass))]
        public IHttpActionResult PostShClass(ShClass model)
        {
            ExecuteResult executeResult = new ExecuteResult();

            string objDeclaredName = nameof(model);
            ShClass _model = EncodeModel(model);

            ModelState.Remove($"{objDeclaredName}.ShClassNo");
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

                //var ModelStateErrors = ModelState.Where(x => x.Value.Errors.Count > 0)
                //    .ToDictionary(k => k.Key, k => k.Value.Errors.Select(e => e.ErrorMessage).ToArray());
                string message = JsonConvert.SerializeObject(errorList);

                executeResult.Code = ((int)Code.ModelValid).ToString();
                executeResult.Message = message;
                string result = JsonConvert.SerializeObject(executeResult);
                return BadRequest(result);
            }

            try
            {
                int result = service.Create(_model);
                if (result == 1)
                    return CreatedAtRoute("DefaultApi", new { id = _model.ShClassNo }, _model);
                else
                    return BadRequest(AllShowResource.DataProcessError);
            }
            catch (Exception)
            {
                return BadRequest(AllShowResource.DataProcessError);
            }
        }

        // DELETE: api/ShClasses/5
        [System.Web.Http.HttpDelete]
        [ResponseType(typeof(ShClass))]
        public IHttpActionResult DeleteShClass(int id)
        {
            ShClass shClass = service.FindOne(m => m.ShClassNo == id);
            if (shClass == null)
            {
                return NotFound();
            }

            int result = service.Delete(shClass);
            if (result != 1)
            {
                return BadRequest();
            }

            return Ok(shClass);
        }
    }
}