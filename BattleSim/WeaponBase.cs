using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BattleSim
{
    /// <summary>
    /// Abstract class to load weapon characteristics from xml
    /// </summary>
    public abstract class WeaponBase
    {
        /// <summary>
        /// Base damage.  Starting point for coming up with damage values during attacks
        /// </summary>
        public int BaseDamage { get; protected set; }

        /// <summary>
        /// Base attribute used when determining attribute bonuses when using a weapon
        /// Currently not implemented
        /// </summary>
        public Enums.CharacterAttributes BaseAttribute { get; protected set; }

        /// <summary>
        /// Base durability to determine if weapon is close to breaking
        /// Currently not implemented.  May never implement, not sure if it adds "fun"
        /// </summary>
        public int BaseDurability { get; protected set; }
    }
}
