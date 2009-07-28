using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleSim.Utility;

namespace BattleSim
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlFileWriter target = new XmlFileWriter();
            Console.WriteLine("Creating Human...");
            target.WriteRaceXml("Human", 20, 20, 20, 20, 20);
            Console.WriteLine("Creating Dwarf...");
            target.WriteRaceXml("Dwarf", 25, 30, 15, 20, 10);
            Console.Read();

        }
    }
}
