using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Party party = new Party();
            Hero hero1 = new Hero();
            hero1.Name = "Cloud";
            hero1.RuneClasses.Add(new Thief());
            Hero hero2 = new Hero();
            hero2.Name = "Snow";
            hero2.RuneClasses.Add(new Mage());
            Hero hero3 = new Hero();
            hero3.Name = "Lightning";
            hero3.RuneClasses.Add(new Warrior());
            Hero hero4 = new Hero();
            hero4.Name = "Storm";
            party.Characters.Add(hero1);
            party.Characters.Add(hero2);
            party.Characters.Add(hero3);
            party.Characters.Add(hero4);
            


            Hero test = (Hero)party.Characters[0];
            Console.WriteLine(test.Equipment.StrengthBonus);
            party.printCharacterStats(party.Characters);


            hero1.addRune(new Fire());
            hero1.addRune(new Cure());
            hero2.addRune(new Fire());
            hero2.addRune(new Cure());

            while (hero1.CurHp > 0 && hero2.CurHp > 0)
            {
                hero1.Runes[0].specialAbility(hero1, hero2);
                if (hero2.CurHp > 0)
                {
                    if (hero2.CurHp < 100 && hero2.CurRunePower > hero2.Runes[1].RunePowerCost)
                    {
                        hero2.Runes[1].specialAbility(hero2, hero2);
                    }
                    else
                    {
                        hero2.Runes[0].specialAbility(hero2, hero1);
                    }
                }
            }
            if (hero1.CurHp > 0)
            {
                Console.WriteLine(hero1.Name + " is victorious");
            }
            else
            {
                Console.WriteLine(hero2.Name + " is victorious");
            }

            //runes[0].specialAbility();
            //runes[1].specialAbility();
            //runes[2].specialAbility();
            
            Console.ReadLine();
        }
    }
}
