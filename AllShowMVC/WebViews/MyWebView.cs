using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AllShowMVC.WebViews
{
    public class MyWebView<T> : WebViewPage<T>
    {

        public override void InitHelpers()
        {
            base.InitHelpers();
        }

        public override void Execute()
        {
        }
    }
}