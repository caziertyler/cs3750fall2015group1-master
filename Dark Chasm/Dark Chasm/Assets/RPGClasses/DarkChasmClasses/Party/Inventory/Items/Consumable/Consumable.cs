using System.Collections.Generic;
using UnityEngine;

namespace RPGClasses
{

    /// <summary>
    /// Defines a structure for all items that can be consumed by a hero.  These items apply
    /// </summary>
    public abstract class Consumable : ItemAbstract
    {

        /// <summary>
        /// Construct a Consumable object.
        /// </summary>
        /// <param name="Id">int - See ItemAbstract object.</param>
        /// <param name="Name">string- See ItemAbstract object.</param>
        /// <param name="MoneyValue">int - See ItemAbstract object.</param>
        public Consumable(int Id, string Name, int MoneyValue) : base (Id, Name, MoneyValue)
        {
            this.Id = Id;
            this.Name = Name;
            this.MoneyValue = MoneyValue;
        }

        /// <summary>
        /// Applies this ItemAbstract object's effect(s) to a list of characters.
        /// </summary>
        /// <param name="characters">A list of Character objects for which the ItemAbstract object's effect(s) will be applied.</param>
        public abstract void UseItem(List<Character> characters);
    }
}
