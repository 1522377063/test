using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using test.utils;

namespace test
{
    /// <summary>
    /// test 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class test : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void select()
        {
            HttpRequest request = HttpContext.Current.Request;
            Stream stream = request.InputStream;
            StreamReader streamReader = new StreamReader(stream);
            string json = string.Empty;
            json = streamReader.ReadToEnd();
            json = HttpUtility.UrlDecode(json);
            Context.Response.ContentType = "application/json;charset=utf-8";
            Context.Response.ContentEncoding = Encoding.GetEncoding("utf-8");
            Context.Response.Write(ResultUtil.getStandardResult(0,"成功",null));
            Context.Response.End();
        }
    }
}
