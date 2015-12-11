using System.Collections.Generic;
using UnityEngine;

namespace RPGClasses
{

    /// <summary>
    /// An abstract class that defines all ItemAbstract objects that can be equipped.
    /// </summary>
    public abstract class EquippableAbstract : ItemAbstract
	{
        public bool IsEquipped { get; set; }
        public Hero EquippedHero { get; set; }

		/// <summary>
        /// Constructs an EquippableAbstract object.
        /// </summary>
        /// <param name="Id">int - See parent.</param>
        /// <param name="Name">string - See parent.</param>
        /// <param name="MoneyValue">int - See parent.</param>
        public EquippableAbstract(int Id, string Name, int MoneyValue) : base (Id, Name, MoneyValue)
		{
            this.Id = Id;
            this.Name = Name;
            this.MoneyValue = MoneyValue;
            this.IsEquipped = false;
            this.EquippedHero = null;
		}
	}
}

