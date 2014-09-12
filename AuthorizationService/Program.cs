using Microsoft.Owin.Hosting;
using System;
using Thinktecture.IdentityServer.Core.Logging;


namespace AuthorizationService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Auth Server";
            LogProvider.SetCurrentLogProvider(new DiagnosticsTraceLogProvider());

            const string url = "http://localhost:3333/core";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("\n\nServer listening at {0}. Press enter to stop", url);
                Console.ReadLine();
            }
        }
    }
}
