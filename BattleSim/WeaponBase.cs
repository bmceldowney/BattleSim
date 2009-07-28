using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleSim
{
    public abstract class WeaponBase
    {
        public int BaseDamage { get; protected set; }

        public Enums.CharacterAttributes BaseAttribute { get; protected set; }

        public int BaseDurability { get; protected set; }
    }
}
