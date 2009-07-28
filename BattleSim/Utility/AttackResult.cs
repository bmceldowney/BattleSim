using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleSim.Utility
{
    public class AttackResult
    {
        public int DamageDone { get; private set; }

        public bool AttackHit { get; private set; }

        public bool Critical { get; private set; }

        public AttackResult(int damage, bool hit, bool crit)
        {
            this.DamageDone = damage;
            this.AttackHit = hit;
            this.Critical = crit;
        }
    }
}
