using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGClasses
{
    class Fire : Rune
    {
        public static List<string> UsableClasses = new List<string>() { "Squire", "Mage" };
        // id, name, physicalDamage, magicDamage, runePowerCost, isAOE
        public Fire() : base(0, "fire", 0, 25, 25, false, UsableClasses) { }
        
        public override void specialAbility(Character obj1, Character obj2)
        {
            int totalDamage = obj1.MagicDamage + this.MagicDamage;
            obj2.CurHp -= totalDamage;
            Console.WriteLine(obj1.Name + " shoots fire ball at " + obj2.Name + " for " + totalDamage + " damage");
            if(obj2.CurHp < 0)
            {
                obj2.CurHp = 0;
            }
            Console.WriteLine(obj2.Name + " has " + obj2.CurHp + " HP remaining");
        }
    }
	/*
    class Ice : Rune
    {
        public static List<RuneClass> UsableClasses = new List<RuneClass>() { new Squire(), new Mage() };
        // id, name, physicalDamage, magicDamage, runePowerCost, isAOE
        public Ice() : base(1, "ice", 0, 25, 25, false, UsableClasses) { }

        public override void specialAbility(Character obj1, Character obj2)
        {
            Console.WriteLine("Subzero shoot ice blast");
        }
    }

    class Poison : Rune
    {
        public static List<RuneClass> UsableClasses = new List<RuneClass>() {};
        // id, name, physicalDamage, magicDamage, runePowerCost, isAOE
        public Poison() : base(0, "poison", 0, 25, 25, false, UsableClasses) { }

        public override void specialAbility(Character obj1, Character obj2)
        {
            Console.WriteLine("reptile spits poison");
        }
    }
*/
    class Cure : Rune
    {
        public static List<string> UsableClasses = new List<string>() { };
        // id, name, physicalDamage, magicDamage, runePowerCost, isAOE
        public Cure() : base(0, "Cure", 0, 100, 25, false, UsableClasses) { }

        public override void specialAbility(Character obj1, Character obj2)
        {
            int totalHeal = obj1.MagicDamage + this.MagicDamage;
            obj1.CurRunePower -= RunePowerCost;
            obj2.CurHp += totalHeal;
            Console.WriteLine(obj1.Name + " sends a healing wave at " + obj2.Name + " for " + totalHeal + " health");
            if (obj2.CurHp > obj2.Hp)
            {
                obj2.CurHp = obj2.Hp;
            }
            Console.WriteLine(obj2.Name + " has " + obj2.CurHp + " HP remaining");
        }
    }
    
}
