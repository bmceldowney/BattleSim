using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleSim.Utility
{
    /// <summary>
    /// A helper class that holds all the data that results from an attack
    /// </summary>
    public class AttackResult
    {
        /// <summary>
        /// Amount of damage done to health by the attack
        /// </summary>
        public int DamageDone { get; private set; }

        /// <summary>
        /// Did the attack hit?
        /// </summary>
        public bool AttackHit { get; private set; }

        /// <summary>
        /// Was the attack a critical?
        /// </summary>
        public bool Critical { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="damage">Amount of damage done to health by the attack</param>
        /// <param name="hit">Did the attack hit?</param>
        /// <param name="crit">Was the attack a critical?</param>
        public AttackResult(int damage, bool hit, bool crit)
        {
            this.DamageDone = damage;
            this.AttackHit = hit;
            this.Critical = crit;
        }
    }
}
