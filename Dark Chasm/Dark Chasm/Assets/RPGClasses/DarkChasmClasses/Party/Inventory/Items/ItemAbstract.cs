using UnityEngine;

namespace RPGClasses
{
    
	/// <summary>
    /// Abstract class to be used by all items.  Provides necessary commonality to all of the game's ItemAbstract objects.
    /// </summary>
    public abstract class ItemAbstract
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MoneyValue { get; set; }

        /// <summary>
        /// Constructs an ItemAbstract object.
        /// </summary>
        /// <param name="Id">A unique identifier for this ItemAbstract object.</param>
        /// <param name="Name">A string representing the item's name.  Used for item retrieving/equipping.</param>
        /// <param name="MoneyValue">Represents the money value of this object.</param>
        public ItemAbstract (int Id, string Name, int MoneyValue){
            this.Id = Id;
            this.Name = Name;
            this.MoneyValue = MoneyValue;
        } 
	}
}

