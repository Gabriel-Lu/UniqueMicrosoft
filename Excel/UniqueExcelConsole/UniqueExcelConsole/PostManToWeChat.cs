using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueExcelConsole
{
    public static class PostManToWeChat
    {
        public static void PostDataToQing(string airtem, string airhum, string oilhum, string light)
        {
            var client = new RestClient("http://139.198.18.176/p/");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "81e3de0a-b969-4288-a2b2-6553e90e35bf");
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("content-type", "multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW");
            request.AddParameter("multipart/form-data; boundary=----WebKitFormBoundary7MA4YWxkTrZu0gW", "------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"airtem\"\r\n\r\n"+airtem+"\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"airhum\"\r\n\r\n"+airhum+"\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"oilhum\"\r\n\r\n"+oilhum+"\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW\r\nContent-Disposition: form-data; name=\"light\"\r\n\r\n"+light+"\r\n------WebKitFormBoundary7MA4YWxkTrZu0gW--", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Debug.WriteLine("一条数据上传完成");
        }
    }
}
