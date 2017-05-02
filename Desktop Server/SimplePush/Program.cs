using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimplePush
{
    class Program
    {
        static void Main(string[] args)
        {

            string localAddress = GetLocalIPAddress();
            Console.WriteLine(localAddress);
            HttpServer httpServer = new SimpleHttpServer(8080);
            Thread thread = new Thread(new ThreadStart(httpServer.listen));
            thread.Start();

        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
    }
}
