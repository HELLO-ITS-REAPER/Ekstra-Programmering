using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml;

namespace Grabbing_The_Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://openweathermap.org/city/2613731";

            var dims = APIProcess(url);

            Console.WriteLine(dims);

            //StringBuilder sb = new StringBuilder();

            //string[] ting = dims.Split("\n");

            //foreach (var item in ting)
            //{
            //    Console.WriteLine(item);
            //    Thread.Sleep(5000);
            //}

        }

        static dynamic APIProcess(string url)
        {
            var webRequest = WebRequest.Create(string.Format(@"{0}", url));

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                return reader.ReadToEnd();
            }

        }

    }
}
