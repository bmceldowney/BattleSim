using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using BattleSim.Utility;

namespace BattleSim
{
    public abstract class CharacterBase : Interfaces.ICharAttributes
    {
        #region Properties

        public RacialBase Race { get; private set; }

        public string Name { get; protected set; }

        public int Level { get; protected set; }

        public WeaponBase Weapon { get; protected set; }

        public int Health { get; protected set; }

        #endregion

        public CharacterBase(string name, RacialBase race)
        {
            this.Health = 100;
            this.Name = name;
            this.Race = race;
            this.InitializeRace(race);
        }

        #region Public Methods

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

        public void LevelUp()
        {
            this.Level++;
        }

        public void LevelUp(int targetLevel)
        {
            if (targetLevel > this.Level)
            {
                this.Level = targetLevel;
            }
        }

        #endregion

        #region Private Methods

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
