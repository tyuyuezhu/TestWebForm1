using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebForm
{
    public class MyHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            HttpRequest request = context.Request;

            Exception ex = context.Server.GetLastError();
            HttpException hex = ex as HttpException;
            if (hex != null && hex.GetHttpCode() == 404)
            {
                context.Server.ClearError();
                response.Redirect("http://www.baidu.com/", true);
            }
        }

        public bool IsReusable
        {
            get
            {
                return true;
                
            }
        }
    }
}