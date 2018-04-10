using Newtonsoft.Json;
using SoftlogTest.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SoftlogTest.Request
{
    public static class ProductController
    {
        static List<Product> list;
        public static List<Product> AllProducts { get {
                if (list == null)
                {
                    list = GetListProduct();
                    return list;
                }
                else
                    return list;
            } }
        static List<Product> GetListProduct()
        {
            List<Product> products = new List<Product>();
            WebRequest webRequest = WebRequest.Create("https://api.myjson.com/bins/mdgob");
            webRequest.Method = WebRequestMethods.Http.Get;
            //httpWebRequest.Accept = "application/json";
            webRequest.Timeout = 10000;
            using (var twitpicResponse = webRequest.GetResponse())
            {
                using (var reader = new StreamReader(twitpicResponse.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    products = JsonConvert.DeserializeObject<List<Product>>(result);
                }
            }

            return products;
        }
    }
}
