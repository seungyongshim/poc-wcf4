namespace ConsoleApp1
{
    using System;
    using System.ServiceModel;
    using WcfServiceLibrary1;

    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(Service1)))
            {
                host.Open();
                Console.ReadLine();
            }
        }
    }
}
