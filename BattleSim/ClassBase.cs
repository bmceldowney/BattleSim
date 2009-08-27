using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleSim
{
    public class ClassBase
    {

        public ClassBase()
        {

        }

        public string Name { get; private set; }

        public int PhysicalStrengthMod { get; private set; }

        public int HardinessMod { get; private set; }

        public int MentalStrengthMod { get; private set; }

        public int SwiftnessMod { get; private set; }

        public int ManualDexterityMod { get; private set; }
    }
}
