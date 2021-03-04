using AddIdentity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AllShowMVC.Areas.WebApi.Controllers
{
    public class BaseApiController : ApiController
    {
        protected NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public BaseApiController()
        {
        }

        public BaseApiController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public BaseApiController(ApplicationUserManager userManager, ApplicationSignInManager signInManager, ApplicationRoleManager roleManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            RoleManager = roleManager;
        }
        
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public ApplicationSignInManager SignInManager
        {
            get => _signInManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
            private set => _signInManager = value;
        }

        public ApplicationUserManager UserManager
        {
            get => _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            private set => _userManager = value;
        }

        private ApplicationRoleManager _roleManager;

        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        protected IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Authentication;
            }
        }

        protected void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        protected string GetEntityErrorMsg(DbEntityValidationException ex)
        {
            var entityError = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);
            var getFullMessage = string.Join("; ", entityError);
            var exceptionMessage = string.Concat(ex.Message, "errors are: ", getFullMessage);
            return exceptionMessage;
        }

        /// <summary>
        /// 取得物件屬性值(Property Value)
        /// </summary>
        /// <param name="src">已宣告的物件</param>
        /// <param name="propName">屬性名稱</param>
        /// <returns></returns>
        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

        /// <summary>
        /// 取得物件屬性名稱(Properties Name)
        /// </summary>
        /// <param name="pObject">任意物件</param>
        /// <returns></returns>
        public static List<string> GetPropertiesNameOfClass(object pObject)
        {
            List<string> propertyList = new List<string>();
            if (pObject != null)
            {
                foreach (var prop in pObject.GetType().GetProperties())
                {
                    propertyList.Add(prop.Name);
                }
            }
            return propertyList;
        }
        /// <summary>
        /// Encode ViewModel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Model"></param>
        /// <returns></returns>
        public static T EncodeModel<T>(T Model) where T : new()
        {
            var classType = typeof(T);
            var expectedType = typeof(string);
            Type myType = typeof(T);

            List<string> PropNames = GetPropertiesNameOfClass(Model);

            foreach (var item in PropNames)
            {
                object value = GetPropValue(Model, item);
                if (value != null)
                {
                    Type valueType = value.GetType();
                    //object is string
                    if (value is string)
                    {
                        if (classType.GetProperty(item).SetMethod != null)
                            classType.GetProperty(item).SetValue(Model, HttpUtility.HtmlEncode(value));
                    }
                    //object is string[]
                    else if (valueType.IsArray && expectedType.IsAssignableFrom(valueType.GetElementType()))
                    {
                        if (classType.GetProperty(item).SetMethod != null)
                            classType.GetProperty(item).SetValue(Model, ((string[])value).Select(s => HttpUtility.HtmlEncode(s)).ToList().ToArray());
                    }
                    //object is List<>
                    else if (value is IList && valueType.IsGenericType && valueType.GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>)))
                    {
                        //object is List<string>
                        if (valueType.GetGenericArguments().Single() == expectedType)
                        {
                            if (classType.GetProperty(item).SetMethod != null)
                                classType.GetProperty(item).SetValue(Model, ((List<string>)value).Select(s => HttpUtility.HtmlEncode(s)).ToList());
                        }
                    }
                }
            }
            return Model;
        }
    }
}