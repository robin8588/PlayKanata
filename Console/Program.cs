using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<WebAPI.Startup>("http://localhost:5000"))
            {
                Console.WriteLine("running");
                Console.ReadLine();
            };
        }
    }
}
