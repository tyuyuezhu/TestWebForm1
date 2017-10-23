using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebForm
{
    public class Error404Module : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            var aa = 1;
            context.Error += new EventHandler(Context_Error);
        }
        protected void Context_Error(object sender, EventArgs e)
        {
            HttpContext ctx = HttpContext.Current;
            HttpResponse response = ctx.Response;
            HttpRequest request = ctx.Request;

            Exception ex = ctx.Server.GetLastError();
            HttpException hex = ex as HttpException;
            if (hex != null && hex.GetHttpCode() == 404)
            {
                ctx.Server.ClearError();
                response.Redirect("http://www.baidu.com/", true);
            }
        }

        public void Dispose()
        {

        }
    }
}