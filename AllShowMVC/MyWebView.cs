using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllShowMVC
{
    public class MyWebView<T> : WebViewPage<T>
    {
        public string MyProperty { get; set; }

        public override void InitHelpers()
        {
            base.InitHelpers();
            MyProperty = "Hello World";
        }

        public override void Execute()
        {
        }
    }
}