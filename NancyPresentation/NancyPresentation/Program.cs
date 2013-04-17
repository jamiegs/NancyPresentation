using Nancy.Hosting.Self;
using System;

namespace NancyPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize an instance of NancyHost (found in the Nancy.Hosting.Self package)
            var host = new NancyHost(new Uri("http://localhost:12345"));

            host.Start(); // start hosting

            Console.ReadKey();

            host.Stop();  // stop hosting
        }
    }
}
