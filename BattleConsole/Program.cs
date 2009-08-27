using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using BattleSim;

namespace BattleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //BattleSim.Utilities.CharacterXmlSerializer serializer;
            RacialBase race;
            //XDocument doc;
            FileInfo file;
            XmlSerializer serializer;
            TextWriter writer;
            RacialBase race2;
            TextReader reader;

            Console.WriteLine("Creating Placeholder");
            race = new RacialBase(string.Empty, 0, 0, 0, 0, 0);
            Console.WriteLine("Creating serializer");
            serializer = new XmlSerializer(typeof(RacialBase));
            file = new FileInfo(@"newClass\Default.xml");
            if (!file.Directory.Exists)
            {
                Console.WriteLine("Creating directory");
                file.Directory.Create();
            }
            
            writer = new StreamWriter(file.FullName);
            Console.WriteLine("Writing stream");
            serializer.Serialize(writer, race);
            writer.Close();

            reader = new StreamReader(file.FullName);
            race2 = (RacialBase)serializer.Deserialize(reader);
            reader.Close();

            Console.WriteLine(string.Format("Name: {0}",race2.Name));
            Console.WriteLine(string.Format("PhysStr: {0}",race2.PhysicalStrength));
            Console.WriteLine(string.Format("MentalStr: {0}",race2.MentalStrength));
            //serializer = new BattleSim.Utilities.CharacterXmlSerializer();


            //Console.WriteLine("Creating Dwarf");
            //doc = serializer.BuildRaceXml("Dwarf", 55, 65, 25, 35, 30);

            //Console.WriteLine("Creating Berserker");
            //doc = serializer.BuildClassXml("Berserker", 10, 15, -10, 0, 10);

            //Console.WriteLine("Creating Grud Henflair");
            //doc = serializer.BuildCharacterXml("Grud Henflair", "Dwarf", "Berserker");
            Console.Read();
        }
    }
}
