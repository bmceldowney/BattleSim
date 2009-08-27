using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using BattleSim.Utilities;

namespace BattleSim
{
    /// <summary>
    /// Class to hold racial characteristics loaded from xml
    /// </summary>
    [XmlRoot("race")]
    public class RacialBase : Interfaces.ICharAttributes
    {
        public RacialBase()
        {

        }

        public RacialBase(string name, int physStr, int hard, int mentalStr, int manDex, int swift)
        {
            this.Name = name;
            this.PhysicalStrength = physStr;
            this.Hardiness = hard;
            this.MentalStrength = mentalStr;
            this.ManualDexterity = manDex;
            this.Swiftness = swift;
        }

        /// <summary>
        /// Constructor.  Loads the racial characteristics from the specified XDocument
        /// </summary>
        /// <param name="raceXml"></param>
        public RacialBase(XDocument raceXml)
        {
            //TODO: Implement loading
        }

        [XmlElement("name")]
        public string Name { get; set; }

        #region ICharAttributes Members

        [XmlElement("physicalStrength")]
        public int PhysicalStrength { get; set; }

        [XmlElement("hardiness")]
        public int Hardiness { get; set; }

        [XmlElement("mentalStrength")]
        public int MentalStrength { get; set; }

        [XmlElement("swiftness")]
        public int Swiftness { get; set; }

        [XmlElement("manualDexterity")]
        public int ManualDexterity { get; set; }

        #endregion
    }
}
