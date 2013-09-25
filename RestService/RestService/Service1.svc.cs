using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
       [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "add/{num1}/{num2}")]

        public string add(string num1, string num2)
        {
            int a = Convert.ToInt32(num1);
            int b = Convert.ToInt32(num2);
            return Convert.ToString(a + b);
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "multiply/{num1}/{num2}")]

        public string multiply(string num1, string num2)
        {
            int a = Convert.ToInt32(num1);
            int b = Convert.ToInt32(num2);
            return Convert.ToString(a * b);
        }

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "subtract/{num1}/{num2}")]

        public string subtract(string num1, string num2)
        {
            int a = Convert.ToInt32(num1);
            int b = Convert.ToInt32(num2);
            return Convert.ToString(a - b);
        }
        
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "divide/{num1}/{num2}")]

        public string divide(string num1, string num2)
        {
            int a = Convert.ToInt32(num1);
            int b = Convert.ToInt32(num2);
            return Convert.ToString(a/b);
        }
        }
    }

