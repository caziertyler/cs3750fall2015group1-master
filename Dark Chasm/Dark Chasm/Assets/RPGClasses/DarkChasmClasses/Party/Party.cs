using System;
using System.Collections.Generic;
using UnityEngine;

namespace RPGClasses
{

    /// <summary>
    /// A 'team' that includes Character objects that can share an Items from a common inventory and can carry gold.
    /// </summary>
    public class Party
    {

        public List<Character> Characters { get; set; }
        public Inventory Inventory { set; get; }
        public int Gold { set; get; }


        /// <summary>
        /// Contructs a Party object.
        /// </summary>
        public Party()
        {
            this.Characters = new List<Character>();
			this.Gold = 0;
			this.Inventory = new Inventory();
        }


        /// <summary>
        /// Prints summary information about each Character in this Party object.
        /// </summary>
        public void printCharacterStats()
        {
            foreach(Hero character in this.Characters)
            {
                Console.WriteLine(character.ToString()+"\n");
            }
        }
    }
}
