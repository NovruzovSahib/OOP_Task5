using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task5
{
    public class IPhone:Phones
    {
        double screenSize;
        byte ram;
        string operationSystem;
        short hdd;
        public double ScreenSize { get; set; }
        public byte Ram { get; set; }
        public string OperationSystem { get; set; }
        public short Hdd { get; set; }

        public IPhone()
        {
            this.ScreenSize = screenSize;
            this.Ram = ram;
            this.OperationSystem = operationSystem;
            this.Hdd = hdd;
        }
        public override void GetElectronics()
        {
            base.GetElectronics();
            Console.WriteLine($"Screen size - {ScreenSize}\nRam - {Ram}\nOperation System - {OperationSystem}\nHDD - {Hdd}\n");
        }
    }
}
