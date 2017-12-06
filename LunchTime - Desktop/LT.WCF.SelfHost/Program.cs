using System;
using System.ServiceModel;
using LT.WCF.Services;

namespace LT.WCF.SelfHost
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                // Vi initialisere en ny service host af typen WcfService fra vores services projekt
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
