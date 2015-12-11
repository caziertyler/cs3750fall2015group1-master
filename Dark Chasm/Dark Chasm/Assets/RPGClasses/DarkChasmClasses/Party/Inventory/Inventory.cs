using System.Collections.Generic;
using UnityEngine;

namespace RPGClasses
{

	/// <summary>
    /// Used by parties of heros and individual enemies. Contains a collection of ItemAbstract objects and some methods for
    /// managing and reporting on these items.
    /// </summary>
    public class Inventory
	{

         private Dictionary<string, ItemAbstract> Items;


		/// <summary>
        /// Constructs an Inventory object.
        /// </summary>
        public Inventory ()
		{
			this.Items = new Dictionary<string, ItemAbstract>();
		}


        /// <summary>
        /// Use an item from Inventory.
        /// </summary>
        /// <param name="itemToUse">The ConsumableItem object to use.</param>
        /// <param name="characters">A List of Chararacter objects to apply item effects.</param>
        public void UseItem(Consumable itemToUse, List<Character> characters)
        {
            if (!Items.ContainsKey(itemToUse.Name))
            {
                itemToUse.UseItem(characters);
                RemoveItem(itemToUse);
            }
        }


        /// <summary>
        /// Adds the ItemAbstract object to 'this.Items'.
        /// </summary>
        /// <param name="itemToAdd">The item to add to the Inventory.</param>
        public void AddItem(ItemAbstract itemToAdd)
        {
            if (!Items.ContainsKey(itemToAdd.Name))
            {
                Items.Add(itemToAdd.Name, itemToAdd);
            }
        }

        /// <summary>
        /// Removes the ItemAbstract object from 'this.Items'.
        /// </summary>
        /// <param name="itemToRemove">The item to remove from the Inventory.</param>
        public void RemoveItem(ItemAbstract itemToRemove)
        {
            if (!Items.ContainsKey(itemToRemove.Name))
            {
                Items.Remove(itemToRemove.Name);
            }
        }
    }
}

