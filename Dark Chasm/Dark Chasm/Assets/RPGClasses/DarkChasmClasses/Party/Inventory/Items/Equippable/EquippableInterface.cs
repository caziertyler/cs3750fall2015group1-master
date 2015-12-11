using UnityEngine;

namespace RPGClasses
{

    /// <summary>
    /// Defines methods to be used by any Item that can be equipped.
    /// </summary>
    interface EquippableInterface
    {

        /// <summary>
        /// Equips the implenting object to a Hero object.
        /// </summary>
        /// <param name="heroToEquip">Hero - The hero for which this item will be equipped.</param>
        void EquipItem(Hero heroToEquip);

        /// <summary>
        /// Unequips the implenting object to a Hero object.
        /// </summary>
        void UnequipItem();
    }
}
