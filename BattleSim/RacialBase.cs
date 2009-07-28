using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using BattleSim.Utility;

namespace BattleSim
{
    public abstract class RacialBase : Interfaces.ICharAttributes
    {
        public RacialBase(XDocument raceXml)
        {

        }

        #region ICharAttributes Members

        public int PhysicalStrength { get; set; }

        public int Hardiness { get; set; }

        public int MentalStrength { get; set; }

        public int Swiftness { get; set; }

        public int ManualDexterity { get; set; }

        #endregion
    }
}
