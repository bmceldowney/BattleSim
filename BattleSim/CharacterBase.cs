using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using BattleSim.Utility;

namespace BattleSim
{
    /// <summary>
    /// This class holds all the properties and methods that are universal to characters in the game
    /// </summary>
    public abstract class CharacterBase : Interfaces.ICharAttributes
    {
        #region Properties

        /// <summary>
        /// The character's race
        /// </summary>
        public RacialBase Race { get; private set; }

        /// <summary>
        /// The character's proper name, e.g. "Sir Percival"
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// The character's current level
        /// </summary>
        public int Level { get; protected set; }

        /// <summary>
        /// The character's weapon.  Currently support for only one weapon
        /// </summary>
        public WeaponBase Weapon { get; protected set; }

        /// <summary>
        /// The character's health.  Commonly known as hit points
        /// </summary>
        public int Health { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The character's proper name, e.g. "Sir Percival"</param>
        /// <param name="race">The character's race</param>
        public CharacterBase(string name, RacialBase race)
        {
            this.Health = 100;
            this.Name = name;
            this.Race = race;
            this.InitializeRace(race);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Perform an attack on a character
        /// </summary>
        /// <param name="character">A reference to the character being attacked</param>
        /// <returns>The result of the attack as an AttackResult object</returns>
        public AttackResult Attack(CharacterBase character)
        {
            //average the Physical Characteristics to determine hit chance
            float hitChance;
            int hitRoll;
            int damage;
            int damageSeed;
            int potentialDamage;
            Random random;

            hitChance = (float)this.PhysicalStrength * 1.25f;
            hitChance += (float)this.ManualDexterity * 2f;
            hitChance += (float)this.Swiftness * 1.25f;
            hitChance -= (float)character.Swiftness;
            hitChance = hitChance / 3;

            random = new Random();
            hitRoll = random.Next(100) + 1;

            if (hitChance > (float)hitRoll)
            {
                damageSeed = Convert.ToInt32(this.PhysicalStrength / 4);
                potentialDamage = damageSeed + this.Weapon.BaseDamage;
                random = new Random();
                damage = this.Weapon.BaseDamage + random.Next(damageSeed) + 1;
                if (damage == potentialDamage)
                {
                    damage = damage * 2;
                    return new AttackResult(damage, true, true);
                }
                return new AttackResult(damage, true, false);
            }

            return new AttackResult(0, false, false);
        }

        /// <summary>
        /// Increases the character's level by 1
        /// </summary>
        public void LevelUp()
        {
            this.Level++;
        }

        /// <summary>
        /// Increases the character's level to the specified level, if this would result in an increase
        /// </summary>
        /// <param name="targetLevel">The level target level</param>
        public void LevelUp(int targetLevel)
        {
            if (targetLevel > this.Level)
            {
                this.Level = targetLevel;
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Add the racial characteristics to the character
        /// </summary>
        /// <param name="race">A reference to the characters race</param>
        private void InitializeRace(RacialBase race)
        {
            foreach (PropertyInfo property in this.GetType().GetProperties())
            {
                object value;

                value = race.GetType().GetProperty(property.Name);
                property.SetValue(this, value, null);
            }
        }

        #endregion

        #region ICharAttributes Members

        public int PhysicalStrength { get; set; }

        public int Hardiness { get; set; }

        public int MentalStrength { get; set; }

        public int Swiftness { get; set; }

        public int ManualDexterity { get; set; }

        #endregion
    }
}
