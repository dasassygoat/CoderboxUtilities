using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace CoderboxUtilities
{
    class Program
    {
        private static List<Computer> computers = new List<Computer>();
        static void Main(string[] args)
        {
            if (args.Contains("ip"))
            {
                
                var server = Dns.GetHostName();
                IPHostEntry heserver = Dns.GetHostEntry(server);
                Regex rex = new Regex(@"^192.168.1.[0-9][0-9]?[0-9]?[0-9]?");
                foreach (IPAddress curAddress in heserver.AddressList)
                {
                    if (rex.Match(curAddress.ToString()).Success)
                    {
                        //Console.WriteLine("Address: " + curAddress.ToString());
                        //var newComputer = new Computer(server, curAddress);
                       computers.Add(new Computer(server, curAddress));
                    } //Console.WriteLine("Address: " + curAddress.ToString()); 
                }

                if (computers.Any())
                {
                    Console.WriteLine("Found IP");
                    foreach (Computer cmp in computers)
                    {
                        Console.WriteLine($"ComputerName: {cmp.GetComputerName()} IP: {cmp.GetIpAddress().ToString()}");
                    }
                }

                //System.Net.IPAddress. arse().Address.ToString();
            }
            else
            {
                Console.WriteLine("Nope");
            }
        }
    }
}
