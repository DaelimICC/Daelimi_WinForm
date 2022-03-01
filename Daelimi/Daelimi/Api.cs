using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Daelimi
{
    internal class Api
    {
        public string Api_Post(String message, int filter)
        {
            string url = "http://141.164.61.172:8000/api/"; 
            string result = String.Empty;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);

            request.Method = "POST";
            request.ContentType = "application/json";

            JObject data = new JObject();
            data.Add("message", message);
            data.Add("isFilter", filter);

            StreamWriter reqStream = new StreamWriter(request.GetRequestStream());
            reqStream.Write(data);
            reqStream.Close();

            try
            {
                HttpWebResponse response = (HttpWebResponse) request.GetResponse();
                StreamReader respStream = new StreamReader(response.GetResponseStream());
                string jsonresult = respStream.ReadToEnd();
                respStream.Close();

                JObject ret = JObject.Parse(jsonresult);
                result = $"{ret["answer"]}";

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
    }
}
