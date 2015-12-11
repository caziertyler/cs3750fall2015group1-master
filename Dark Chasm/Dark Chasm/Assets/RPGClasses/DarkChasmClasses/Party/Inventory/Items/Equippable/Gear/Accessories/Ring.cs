using System;
using UnityEngine;

namespace RPGClasses
{

    /// <summary>
    /// Provides Bonuses/Penalties to a Hero object.
    /// </summary>
    public class Ring : GearAbstract, HandheldInterface
    {
        private Hero.Hand EquippedHand;

        /// <summary>
        /// Builds a Ring Object. For parameter descriptions, see GearAbstract.
        /// </summary>
        /// <param name="Id">int - See ItemAbstract object.</param>
        /// <param name="Name">string - See ItemAbstract object.</param>
        /// <param name="MoneyValue">int - See ItemAbstract object.</param>
        /// <param name="StrengthBonus">int - See GearAbstract object.</param>
        /// <param name="PhysicalDamageBonus">int - See GearAbstract object.</param>
        /// <param name="PhysicalDefenseBonus">int - See GearAbstract object.</param>
        /// <param name="CriticalStrikeBonus">double - See GearAbstract object.</param>
        /// <param name="HpBonus">int - See GearAbstract object.</param>
        /// <param name="IntelligenceBonus">int - See GearAbstract object.</param>
        /// <param name="MagicDamageBonus">int - See GearAbstract object.</param>
        /// <param name="MagicDefenseBonus">int - See GearAbstract object.</param>
        /// <param name="FireDefenseBonus">int - See GearAbstract object.</param>
        /// <param name="IceDefenseBonus">int - See GearAbstract object.</param>
        /// <param name="ShockDefenseBonus">int - See GearAbstract object.</param>
        /// <param name="PoisonDefenseBonus">int - See GearAbstract object.</param>
        /// <param name="FireEvadeBonus">double - See GearAbstract object.</param>
        /// <param name="IceEvadeBonus">double - See GearAbstract object.</param>
        /// <param name="ShockEvadeBonus">double - See GearAbstract object.</param>
        /// <param name="PoisonEvadeBonus">double - See GearAbstract object.</param>
        /// <param name="AlterSuccessRateBonus">double - See GearAbstract object.</param>
        /// <param name="AlterEvadeBonus">double - See GearAbstract object.</param>
        /// <param name="RunePowerBonus">int - See GearAbstract object.</param>
        /// <param name="AgilityBonus">int - See GearAbstract object.</param>
        /// <param name="EscapeBonus">double - See GearAbstract object.</param>
        /// <param name="EvadeBonus">double - See GearAbstract object.</param>
        /// <param name="AccuracyBonus">double - See GearAbstract object.</param>
        /// <param name="SpeedBonus">double - See GearAbstract object.</param>
        public Ring
            (
                int Id, string Name, int MoneyValue, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
                int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0, int IntelligenceBonus = 0,
                int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
                int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
                double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0,
                double AlterEvadeBonus = 0, int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0,
                double EvadeBonus = 0, double AccuracyBonus = 0, int SpeedBonus = 0
            ) : base
            (
                Id, Name, MoneyValue, StrengthBonus, PhysicalDamageBonus, PhysicalDefenseBonus, CriticalStrikeBonus, HpBonus,
                IntelligenceBonus, MagicDamageBonus, MagicDefenseBonus, FireDefenseBonus, IceDefenseBonus,
                ShockDefenseBonus, PoisonDefenseBonus, FireEvadeBonus, IceEvadeBonus, ShockEvadeBonus, PoisonEvadeBonus,
                AlterSuccessRateBonus, AlterEvadeBonus, RunePowerBonus, AgilityBonus, EscapeBonus, EvadeBonus,
                AccuracyBonus, SpeedBonus
            )
        {
            EquippedHand = Hero.Hand.Main;
        }


        /// <summary>
        /// Not implemented.
        /// </summary>
        /// <param name="heroToEquip"></param>
        public override void EquipItem(Hero heroToEquip)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Equips 'this' Ring object to a Hero.
        /// </summary>
        /// <param name="heroToEquip">The Hero to which 'this' Item will be equipped.</param>
        /// <param name="handToEquip">The Hand to which 'this' Item will be equipped.</param>
        public void EquipItem(Hero heroToEquip, Hero.Hand handToEquip)
        {
            if (IsEquipped == true)
            {
                UnequipItem();
            }

            if (handToEquip == Hero.Hand.Main)
            {
                heroToEquip.Equipment.Ring1.UnequipItem();
                heroToEquip.Equipment.Ring1 = this;
            }
            else
            {
                heroToEquip.Equipment.Ring2.UnequipItem();
                heroToEquip.Equipment.Ring2 = this;
            }
            EquippedHand = handToEquip;
            EquippedHero = heroToEquip;
            IsEquipped = true;
        }


        /// <summary>
        /// Unequips this item from the Hero object.
        /// </summary>
        public override void UnequipItem()
        {
            if (IsEquipped && EquippedHero != null)
            {
                if (EquippedHand == Hero.Hand.Main)
                {
                    EquippedHero.Equipment.Ring1 = GearList.GetRingList()["None"];
                }
                else
                {
                    EquippedHero.Equipment.Ring2 = GearList.GetRingList()["None"];
                }
                EquippedHero = null;
                IsEquipped = false;
            }
        }
    }
}
