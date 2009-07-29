using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using BattleSim.Utility;

namespace BattleSim
{
    /// <summary>
    /// Abstract class to hold racial characteristics loaded from xml
    /// </summary>
    public abstract class RacialBase : Interfaces.ICharAttributes
    {
        /// <summary>
        /// Constructor.  Loads the racial characteristics from the specified XDocument
        /// </summary>
        /// <param name="raceXml"></param>
        public RacialBase(XDocument raceXml)
        {
            //TODO: Implement loading
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
