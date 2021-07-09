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
using AllShowMVC.Infrastructure;
using AllShowMVC.Models;
using AllShowMVC.Service;

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
        public IHttpActionResult PutShClass(int id, ShClass shClass)
        {
            ShClass model = EncodeModel(shClass);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shClass.ShClassNo)
            {
                return BadRequest();
            }

            try
            {
                int result = service.Update(model);
                if (result != 1)
                    return BadRequest("更新失敗");
            }
            catch (DbUpdateConcurrencyException ex)
            {
                logger.Error(ex.Message);
                return BadRequest("更新失敗");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return BadRequest("更新失敗");
            }

            return Content(HttpStatusCode.OK, model);
        }

        // POST: api/ShClasses
        [System.Web.Http.HttpPost]
        [ValidateAntiForgeryToken]
        [ResponseType(typeof(ShClass))]
        public IHttpActionResult PostShClass(ShClass shClass)
        {
            ShClass model = EncodeModel(shClass);

            ModelState.Remove("shClass.ShClassNo");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int result = service.Create(model);
            if (result != 1)
            {
                return BadRequest("新增失敗");
            }

            return CreatedAtRoute("DefaultApi", new { id = model.ShClassNo }, model);
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
                return BadRequest("刪除失敗");
            }

            return Ok(shClass);
        }
    }
}