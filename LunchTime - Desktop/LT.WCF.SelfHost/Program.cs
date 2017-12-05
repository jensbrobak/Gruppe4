using System;
using System.ServiceModel;
using LT.WCF.Services;

namespace LT.WCF.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost host = new ServiceHost(typeof(WcfService));
                host.Open();
                Console.WriteLine("Tryk på en tast for at afslutte programmet");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}
