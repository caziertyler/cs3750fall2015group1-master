using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGClasses
{
    abstract class Rune
    {
        private int Id { get; set; } 
        public string Name { get; set; }
        public int PhysicalDamage { get; set; }
        public int MagicDamage { get; set; }
        public int RunePowerCost { get; set; }
        public bool IsAOE { get; set; }
        public List<string> RuneClasses { get; set; }
        
        public Rune(int Id, string Name, int PhysicalDamage, int MagicDamage, int RunePowerCost, bool IsAOE, List<string> RuneClasses)
        {
            this.Id = Id;
            this.Name = Name;
            this.PhysicalDamage = PhysicalDamage;
            this.MagicDamage = MagicDamage;
            this.RunePowerCost = RunePowerCost;
            this.IsAOE = IsAOE;
            this.RuneClasses = RuneClasses;
        }

        public abstract void specialAbility(Character obj1, Character obj2);
    }
}
