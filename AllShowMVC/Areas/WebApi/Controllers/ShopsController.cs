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
using AllShowMVC.App_Class.Base;
using AllShowMVC.Common;
using AllShowMVC.Infrastructure;
using AllShowMVC.Models;
using AllShowMVC.Models.IdentityModel;
using AllShowMVC.Models.ViewModel;
using AllShowMVC.Service;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace AllShowMVC.Areas.WebApi.Controllers
{
    public class ShopsController : BaseApiController
    {
        readonly ShopService service;
        public ShopsController()
        {
            service = new ShopService();
        }

        // GET: api/Shops
        [System.Web.Http.HttpGet]
        public ApiReponse<List<Shop>> GetShop()
        {
            var result = service.GetAll().AsEnumerable().Select(
                m => new Shop
                {
                    ShNo = m.ShNo,
                    ShThePic = m.ShThePic,
                    ShName = m.ShName,
                    ShClassNo = m.ShClassNo,
                    ShBoss = m.ShBoss,
                    ShContact = m.ShContact,
                    ShAddress = m.ShAddress,
                    ShTel = m.ShTel
                }).ToList();
            return new ApiReponse<List<Shop>>(result);
        }

        // GET: api/Shops/5
        [System.Web.Http.HttpGet]
        [ResponseType(typeof(Shop))]
        public IHttpActionResult GetShop(int id)
        {
            Shop shop = service.FindOne(m => m.ShNo == id);
            if (shop == null)
            {
                return NotFound();
            }

            return Ok(shop);
        }
        /*
        // PUT: api/Shops/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutShop(int id, Shop shop)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shop.ShNo)
            {
                return BadRequest();
            }

            db.Entry(shop).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShopExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        */
        // POST: api/Shops
        [System.Web.Http.HttpPost]
        [ValidateAntiForgeryToken]
        [ResponseType(typeof(Shop))]
        public IHttpActionResult PostShop(/*Shop model*/)
        {
            string ShName = BaseUtility.GetRequest("ShName", false);

            string test = Security.EncryptDES(ShName);
            string test2 = Security.DecryptDES(test);

            //取得當前的 request 物件
            var httpRequest = HttpContext.Current.Request;
            //request 如有夾帶檔案
            if (httpRequest.Files.Count > 0)
            {
                //逐一取得檔案名稱
                foreach (string fileName in httpRequest.Files.Keys)
                {
                    //以檔案名稱從 request 的 Files 集合取得檔案內容
                    var file = httpRequest.Files[fileName];
                    //其他檔案處理
                }

                //return Request.CreateResponse(HttpStatusCode.OK);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //db.Shop.Add(shop);
            //db.SaveChanges();

            //return CreatedAtRoute("DefaultApi", new { id = model.ShNo }, model);
            return Ok();
        }
        /*
        // DELETE: api/Shops/5
        [ResponseType(typeof(Shop))]
        public IHttpActionResult DeleteShop(int id)
        {
            Shop shop = db.Shop.Find(id);
            if (shop == null)
            {
                return NotFound();
            }

            db.Shop.Remove(shop);
            db.SaveChanges();

            return Ok(shop);
        }
        */
    }
}