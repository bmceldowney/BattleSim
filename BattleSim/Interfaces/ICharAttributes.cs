using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleSim.Interfaces
{
    interface ICharAttributes
    {
        #region Character Attributes

        int PhysicalStrength { get; set; }

        int Hardiness { get; set; }

        int MentalStrength { get; set; }

        int Swiftness { get; set; }

        int ManualDexterity { get; set; }

        #endregion
    }
}
