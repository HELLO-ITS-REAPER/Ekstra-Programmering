using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using System.IO;

namespace Grabbing_The_Weather
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("What city do you want the weather from?");
            string city = Console.ReadLine();
            string uri = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=017de5bb94b69748ca7201e46d9f4c5e&units=metric";

            HttpClient client = new HttpClient();
            var request = await client.GetAsync("https://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=017de5bb94b69748ca7201e46d9f4c5e&units=metric");
            var response = request.Content.ReadAsStringAsync();
            Console.Read();
        }
    }
}
