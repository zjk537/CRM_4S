using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace CRM_4S.Service.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(DataService.DataService));

            host.Open();

            Console.WriteLine("Service Opened");

            Console.ReadLine();
        }
    }
}
