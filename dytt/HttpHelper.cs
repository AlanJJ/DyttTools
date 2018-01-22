using CsharpHttpHelper;
using FKSharp.Utility.Data;
using System;
using System.Net;

namespace dytt
{
    public class SimpleHttpHelper
    {
        public static OperationResult Get(string url)
        {
            try
            {
                //创建Httphelper对象
                HttpHelper http = new HttpHelper();
                //创建Httphelper参数对象
                HttpItem item = new HttpItem()
                {
                    URL = url,//URL     必需项    
                    ContentType = "application/x-www-form-urlencoded",//返回类型    可选项有默认值
                };
                //请求的返回值对象
                HttpResult result = http.GetHtml(item);
                //获取请请求的Html
                string html = result.Html;
                //LogHelper.WriteLog(html);
                //获取请求的Cookie
                string cookie = result.Cookie;
                //状态码
                HttpStatusCode code = result.StatusCode;
                //状态描述
                string Des = result.StatusDescription;
                if (code != HttpStatusCode.OK)
                {
                    //状态为200
                    return new OperationResult(OperationResultType.Error, "执行失败");
                }
                return new OperationResult(OperationResultType.Success, "执行成功", html);

            }
            catch (Exception ex)
            {
                return new OperationResult(OperationResultType.Error, ex.Message);
            }
        }
        /// <summary>
        /// POST
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postdata">如：a=123&c=456&d=789</param>
        public static OperationResult Post(string url, string postdata)
        {
            try
            {
                //创建Httphelper对象
                HttpHelper http = new HttpHelper();
                //创建Httphelper参数对象
                HttpItem item = new HttpItem()
                {
                    URL = url,//URL     必需项    
                    Method = "post",//URL     可选项 默认为Get   
                    ContentType = "application/x-www-form-urlencoded;charset=gb2312",//返回类型    可选项有默认值
                    Postdata = postdata,//Post要发送的数据
                };
                //请求的返回值对象
                HttpResult result = http.GetHtml(item);
                //获取请请求的Html
                string html = result.Html;
              
                //获取请求的Cookie
                string cookie = result.Cookie;
                //状态码
                HttpStatusCode code = result.StatusCode;
                //状态描述
                string Des = result.StatusDescription;
                if (code != HttpStatusCode.OK)
                {
                    //状态为200
                    return new OperationResult(OperationResultType.Error, "执行失败");
                }
                return new OperationResult(OperationResultType.Success, "执行成功", html);

            }
            catch (Exception ex)
            {
                return new OperationResult(OperationResultType.Error, ex.Message);
            }
        }
    }
}
