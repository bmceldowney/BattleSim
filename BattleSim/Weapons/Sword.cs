using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleSim.Weapons
{
    class Sword : WeaponBase
    {
        public Sword()
        {
            this.BaseAttribute = Enums.CharacterAttributes.Swiftness;
            this.BaseDamage = 5;
            this.BaseDurability = 25;
        }
    }
}
