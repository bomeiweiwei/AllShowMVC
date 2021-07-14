using Microsoft.Security.Application;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AllShowMVC.Common
{
    public class BaseUtility
    {
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

        public static string GetRequest(string strRequestName, bool blEncode = false)
        {
            string strRequestValue = "";

            if (HttpContext.Current.Request[strRequestName] != null)
            {
                strRequestValue = HttpContext.Current.Request[strRequestName].ToString();

                if (blEncode)
                {
                    try
                    {
                        strRequestValue = Security.DecryptDES(HttpContext.Current.Request[strRequestName].ToString());
                    }
                    catch
                    {
                        strRequestValue = "";
                    }
                }
                strRequestValue = GetSafeHtmlFragment(strRequestValue);
            }

            return strRequestValue;
        }
        public static string GetSafeHtmlFragment(string strHtml)
        {
            return Sanitizer.GetSafeHtmlFragment(strHtml.Replace("javascript:", ""));
        }
    }
}
