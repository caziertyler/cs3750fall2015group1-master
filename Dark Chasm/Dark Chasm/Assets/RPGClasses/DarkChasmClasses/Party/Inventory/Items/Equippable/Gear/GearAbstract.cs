using UnityEngine;

namespace RPGClasses
{

	/// <summary>
    /// An abstract class used for all weapons, armor, and accessory items that can be equipped by a hero.
    /// </summary>
    public abstract class GearAbstract : EquippableAbstract, EquippableInterface
    {
        //Strength and its subattributes
        public int StrengthBonus { get; set; }
        public int PhysicalDamageBonus { get; set; }
        public int PhysicalDefenseBonus { get; set; }
        public double CriticalStrikeBonus { get; set; }
        public int HpBonus { get; set; }

        //Intelligence and its subattributes
        public int IntelligenceBonus { get; set; }
        public int MagicDamageBonus { get; set; }
        public int MagicDefenseBonus { get; set; }
        public int FireDefenseBonus { get; set; }
        public int IceDefenseBonus { get; set; }
        public int ShockDefenseBonus { get; set; }
        public int PoisonDefenseBonus { get; set; }
        public double FireEvadeBonus { get; set; }
        public double IceEvadeBonus { get; set; }
        public double ShockEvadeBonus { get; set; }
        public double PoisonEvadeBonus { get; set; }
        public double AlterSuccessRateBonus { get; set; }
        public double AlterEvadeBonus { get; set; }
        public int RunePowerBonus { get; set; }

        //Agility and its subattributes
        public int AgilityBonus { get; set; }
        public double EscapeBonus { get; set; }
        public double EvadeBonus { get; set; }
        public double AccuracyBonus { get; set; }
        public int SpeedBonus { get; set; }


        /// <summary>
        /// A constructor with values to be constructed by every Accessory, Armor, and Weapon object used by heros.
        /// </summary>
        /// <param name="Id">int - A unique identifier for the object.</param>
        /// <param name="Name">string - Describes the Gear piece.</param>
        /// <param name="Value">int - An int value representing the cost for a particular item.</param>
        /// <param name="StrengthBonus">int - Bonus points to add to wearer Hero object's Strength.</param>
        /// <param name="PhysicalDamageBonus">int - Bonus points to add to wearer Hero object's PhysicalDamge.</param>
        /// <param name="PhysicalDefenseBonus">int - Bonus points to add to wearer Hero object's PhysicalDefense.</param>
        /// <param name="CriticalStrikeBonus">double - Bonus percentage to add to wearer Hero object's CriticalStrike.</param>
        /// <param name="HpBonus">int - Bonus points to add to wearer Hero object's HP.</param>
        /// <param name="IntelligenceBonus">int - Bonus points to add to wearer Hero object's Intelligence.</param>
        /// <param name="MagicDamageBonus">int - Bonus points to add to wearer Hero object's MagicDamage.</param>
        /// <param name="MagicDefenseBonus">int - Bonus points to add to wearer Hero object's MagicDefense.</param>
        /// <param name="FireDefenseBonus">int - Bonus points to add to wearer Hero object's FireDefense.</param>
        /// <param name="IceDefenseBonus">int - Bonus points to add to wearer Hero object's IceDefense.</param>
        /// <param name="ShockDefenseBonus">int - Bonus points to add to wearer Hero object's ShockDefense.</param>
        /// <param name="PoisonDefenseBonus">int - Bonus points to add to wearer Hero object's PoisonDefense.</param>
        /// <param name="FireEvadeBonus">double - Bonus percentage to add to wearer Hero object's FireEvade.</param>
        /// <param name="IceEvadeBonus">double - Bonus percentage to add to wearer Hero object's IceEvade.</param>
        /// <param name="ShockEvadeBonus">double - Bonus percentage to add to wearer Hero object's ShockEvade.</param>
        /// <param name="PoisonEvadeBonus">double - Bonus percentage to add to wearer Hero object's PoisonEvade.</param>
        /// <param name="AlterSuccessRateBonus">double - Bonus percentage to add to wearer Hero object's AlterSuccessRate.</param>
        /// <param name="AlterEvadeBonus">double - Bonus percentage to add to wearer Hero object's AlterEvade.</param>
        /// <param name="RunePowerBonus">int - Bonus points to add to wearer Hero object's RunePower.</param>
        /// <param name="AgilityBonus">int - Bonus points to add to wearer Hero object's Agility.</param>
        /// <param name="EscapeBonus">double - Bonus percentage to add to wearer Hero object's Escpae.</param>
        /// <param name="EvadeBonus">double - Bonus percentage to add to wearer Hero object's Evade.</param>
        /// <param name="AccuracyBonus">double - Bonus percentage to add to wearer Hero object's Accuracy.</param>
        /// <param name="SpeedBonus">int - Bonus points to add to wearer Hero object's Speed.</param>
        public GearAbstract
            (
                int Id, string Name, int MoneyValue, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
                int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0,
                int IntelligenceBonus = 0, int MagicDamageBonus = 0, int MagicDefenseBonus = 0,
                int FireDefenseBonus = 0, int IceDefenseBonus = 0,  int ShockDefenseBonus = 0,
                int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
                double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0,
                double AlterEvadeBonus = 0, int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0,
                double EvadeBonus = 0, double AccuracyBonus = 0,int SpeedBonus = 0
            ) : base
            (
                   Id, Name, MoneyValue
            )
        {
            this.Id = Id;
            this.Name = Name;
            this.MoneyValue = MoneyValue;
            this.StrengthBonus = StrengthBonus;
            this.PhysicalDamageBonus = PhysicalDamageBonus;
            this.PhysicalDefenseBonus = PhysicalDefenseBonus;
            this.CriticalStrikeBonus = CriticalStrikeBonus;
            this.HpBonus = HpBonus;
            this.IntelligenceBonus = IntelligenceBonus;
            this.MagicDamageBonus = MagicDamageBonus;
            this.MagicDefenseBonus = MagicDefenseBonus;
            this.FireDefenseBonus = FireDefenseBonus;
            this.IceDefenseBonus = IceDefenseBonus;
            this.ShockDefenseBonus = ShockDefenseBonus;
            this.PoisonDefenseBonus = PoisonDefenseBonus;
            this.FireEvadeBonus = FireEvadeBonus;
            this.IceEvadeBonus = IceEvadeBonus;
            this.ShockEvadeBonus = ShockEvadeBonus;
            this.PoisonEvadeBonus = PoisonEvadeBonus;
            this.AlterSuccessRateBonus = AlterSuccessRateBonus;
            this.AlterEvadeBonus = AlterEvadeBonus;
            this.RunePowerBonus = RunePowerBonus;
            this.AgilityBonus = AgilityBonus;
            this.EscapeBonus = EscapeBonus;
            this.EvadeBonus = EvadeBonus;
            this.AccuracyBonus = AccuracyBonus;
            this.SpeedBonus = SpeedBonus;
        }

        /// <summary>
        /// See EquippableAbstract.
        /// </summary>
        /// <param name="heroToEquip"></param>
        public abstract void EquipItem(Hero heroToEquip);

        /// <summary>
        /// See EquippableAbstract.
        /// </summary>
        /// <param name="heroToEquip"></param>
        public abstract void UnequipItem();

    }
}