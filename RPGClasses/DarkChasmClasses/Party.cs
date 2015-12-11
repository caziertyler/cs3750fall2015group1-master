using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGClasses
{
    class Party
    {
        public List<Character> Characters
        {
            get; set;
        } 

        public Party()
        {
            this.Characters = new List<Character>();
        }
        public void printCharacterStats(List<Character> characters)
        {
            foreach(Hero character in characters)
            {
                Console.WriteLine(character.ToString()+"\n");
            }
        }
    }
}
