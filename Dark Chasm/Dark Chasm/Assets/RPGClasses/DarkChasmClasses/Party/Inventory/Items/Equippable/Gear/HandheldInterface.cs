using UnityEngine;

namespace RPGClasses
{

    /// <summary>
    /// For EquippableItem objects that require the player to specify which hand to equip.
    /// </summary>
    public interface HandheldInterface
    {
        void EquipItem(Hero heroToEquip, Hero.Hand handToEquip = Hero.Hand.Main);
    }
}
