using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CoderboxLibrary
{
    public class Computer
    {
        public Computer(string ComputerName, IPAddress ipAddress)
        {
            this.ComputerName = ComputerName;
            this.ipAddress = ipAddress;
        }

        public void UpdateIpAddress(IPAddress newIpAddress)
        {
            this.ipAddress = newIpAddress;
        }

        public IPAddress GetIpAddress()
        {
            return this.ipAddress;
        }

        public string GetComputerName()
        {
            return this.ComputerName;
        }
        private string ComputerName { get; set; }
        private IPAddress ipAddress { get; set; }
    }
}
