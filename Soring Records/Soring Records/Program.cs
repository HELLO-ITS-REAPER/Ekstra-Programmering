using System;
using System.Collections.Generic;

namespace Soring_Records
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> data = new List<List<string>>();
            data.Add(new List<string> { "Martin", "Kjeldsen", "1-1-2020" });
            data.Add(new List<string> { "Anders", "Kjeldsen", "3-5-2020" });
            data.Add(new List<string> { "Gert", "Nielsen", "6-7-1960" });

            var map = data;
            map.Add(new List<string> { "Martin", "Kjeldsen", "1-1-2020" });
            map.Add(new List<string> { "Anders", "Kjeldsen", "3-5-2020" });
            map.Add(new List<string> { "Gert", "Nielsen", "6-7-1960" });
        }
    }
}
