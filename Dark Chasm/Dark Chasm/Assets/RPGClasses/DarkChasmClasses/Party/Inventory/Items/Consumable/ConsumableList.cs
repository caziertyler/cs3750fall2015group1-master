using System;
using System.Collections.Generic;
using UnityEngine;

namespace RPGClasses
{

    /// <summary>
    /// A predefined list of all consumable ItemAbstract objects that a Character object can use during the game.  These provide
    /// various benefits/penalties for/to a Character object.
    /// </summary>
    class ConsumableList
    {
        // ---------- Consumable Items ----------- //

        /// <summary>
        /// Potion - Restores 50 HP to one Character object.
        /// </summary>
        public class Potion : Consumable
        {
            public Potion() : base(0, "Potion", 50)
            { }

            public override void UseItem(List<Character> characters)
            {
                foreach (Character character in characters)
                {
                    if ((character.CurrentHp + 50) < character.Hp)
                        character.CurrentHp += 50;
                    else
                        character.CurrentHp = character.Hp;
                }
            }
        }

        /// <summary>
        /// Ether - Restores 50 RunePower to one Character object.
        /// </summary>
        public class Ether : Consumable
        {
            public Ether() : base(1, "Ether", 50)
            { }

            public override void UseItem(List<Character> characters)
            {
                foreach (Character character in characters)
                {
                    if ((character.CurrentRunePower + 50) < character.RunePower)
                        character.CurrentRunePower += 50;
                    else
                        character.CurrentRunePower = character.RunePower;
                }
            }
        }
    }
}
