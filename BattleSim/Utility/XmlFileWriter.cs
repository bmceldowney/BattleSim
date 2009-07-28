using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using BattleSim;

namespace BattleSim.Utility
{
    class XmlFileWriter
    {
        public void WriteClassXml(string name, int psMod, int hMod, int msMod, int mdMod, int sMod)
        {
            XElement xml;
            FileInfo file;
            string classSubDir = @".\classes";

            file = new FileInfo(Path.Combine(classSubDir, name + ".xml"));
            xml = new XElement("class",
                new XElement("name", name),
                new XElement(Enums.CharacterAttributes.PhysicalStrength.ToString() + "Modfier", psMod),
                new XElement(Enums.CharacterAttributes.Hardiness.ToString() + "Modfier", hMod),
                new XElement(Enums.CharacterAttributes.MentalStrength.ToString() + "Modfier", msMod),
                new XElement(Enums.CharacterAttributes.ManualDexterity.ToString() + "Modfier", mdMod),
                new XElement(Enums.CharacterAttributes.Swiftness.ToString() + "Modfier", sMod)
                );
            this.WriteToFile(file, xml);
        }

        public void WriteRaceXml(string name, int physStr, int hard, int mentStr, int manDex, int swift)
        {
            XElement xml;
            FileInfo file;
            string raceSubDir = @".\races";

            file = new FileInfo(Path.Combine(raceSubDir, name + ".xml"));
            xml = new XElement("race",
                new XElement("name", name),
                new XElement(Enums.CharacterAttributes.PhysicalStrength.ToString(), physStr),
                new XElement(Enums.CharacterAttributes.Hardiness.ToString(), hard),
                new XElement(Enums.CharacterAttributes.MentalStrength.ToString(), mentStr),
                new XElement(Enums.CharacterAttributes.ManualDexterity.ToString(), manDex),
                new XElement(Enums.CharacterAttributes.Swiftness.ToString(), swift)
                );
            this.WriteToFile(file, xml);
        }

        public void WriteCharacterXml(string name, string race, string characterClass)
        {
            XElement xml;
            FileInfo file;
            string characterSubDir = @".\characters";

            file = new FileInfo(Path.Combine(characterSubDir, characterClass + "_" + name + ".xml"));
            xml = new XElement("character",
                new XElement("name", name),
                new XElement("race", race),
                new XElement("class", characterClass)
                );
            this.WriteToFile(file, xml);
        }

        private void WriteToFile(FileInfo file, XElement xml)
        {
            XDocument charDoc;
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.OmitXmlDeclaration = true;
            xws.Indent = true;

            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }

            using (XmlWriter writer = XmlWriter.Create(file.FullName, xws))
            {
                charDoc = new XDocument(xml);
                charDoc.WriteTo(writer);
            }
        }
    }
}
