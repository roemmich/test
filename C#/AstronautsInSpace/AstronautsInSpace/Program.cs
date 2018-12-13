using Newtonsoft.Json.Linq;
using System;
using System.Net;

namespace AstronautsInSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient w = new WebClient())
            {
                var json = w.DownloadString("http://api.open-notify.org/astros.json");
                dynamic stuff = JObject.Parse(json);
                foreach (var item in stuff.people)
                    Console.WriteLine("{0} {1}", item.name, item.craft);
                Console.WriteLine("Anzahl: " + stuff.number);
            }
        }
    }
}
