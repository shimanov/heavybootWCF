using System;
using System.ServiceModel;

namespace HeavyBoot.Host
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(WCFService.Service)))
            {
                host.Open();

                Console.WriteLine("Host started");
                HostInfo(host);
                Console.ReadKey();
            }
        }

        static void HostInfo(ServiceHost host)
        {
            Console.WriteLine("***** Host Info *****");
            foreach (System.ServiceModel.Description.ServiceEndpoint endpoint in host.Description.Endpoints)
            {
                Console.WriteLine("Адрес: {0}", endpoint.Address);
                Console.WriteLine("Привязка: {0}", endpoint.Binding);
                Console.WriteLine("Контракт: {0}", endpoint.Contract);
                Console.WriteLine();
            }
            Console.WriteLine("**********");
        }
    }
}
