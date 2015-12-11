using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGClasses
{
    class Hero : Character
    {
        public int Experience { get; set; }
        public List<RuneClass> RuneClasses { get; set; }
        public Equipment Equipment { get; set; }
        public RuneClass RuneClass { get; set; }

        //    public Character(string Name, int Level, List<Rune> Runes, List<Buff> Buffs, List<Debuff> Debuffs,
        //    int Strength, int PhysicalDamage, int PhysicalDefense, double CriticalStrike, int Hp, int CurHp, int Intelligence,
        //    int MagicDamage, int MagicDefense, int FireDefense, int IceDefense, int ShockDefence, int PoisonDefense,
        //    int FireEvade, int IceEvade, int ShockEvade, int PoisonEvade, int AlterSuccessRate, int AlterEvade,
        //    int RunePower, int CurRunePower int Agility, int Escape, int Evade, int Accuracy, int Speed)
        public Hero() : base("", 1, new List<Rune>(), new List<Buff>(), new List<Debuff>(), 1, 1, 1, 1.0, 300, 300, 1, 30, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 150, 150, 1, 1, 1, 1, 1)
        {
            RuneClasses = new List<RuneClass>();
            RuneClasses.Add(new Squire());
            RuneClass = new Squire();
            Equipment = new Equipment();
        }

        public Hero(int Experience, List<RuneClass> RuneClasses, Equipment Equipment, RuneClass RuneClass) : base("",1,new List<Rune>(),new List<Buff>(),new List<Debuff>(),1,1,1,1.0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,150,1,1,1,1,1,1)
        {
            this.Experience = Experience;
            this.RuneClasses = RuneClasses;
            this.Equipment = Equipment;
            this.RuneClass = RuneClass;
        }
        

        public void addRune(Rune rune)
        {
			//if ((rune.RuneClasses.Where(x => x.Name == this.RuneClass.Name).FirstOrDefault() != null || rune.RuneClasses.Count == 0) && Runes.Where(x => x.Name == rune.Name).FirstOrDefault() == null)

			// if this.runeclass in runeClasses 

			if((rune.RuneClasses.Contains(this.RuneClass.Name)))
			{
				Console.WriteLine(rune.Name);
			}

			if (Runes.Where(x => x.Name == rune.Name).FirstOrDefault() == null)
            {
                Runes.Add(rune);
            }
        }
            

        public override string ToString()
        {
            return string.Format("Name: {0},\nLevel: {1},\nStrength: {2},\nAgility: {3},\nIntelligence: {4}\nEquipment: {5}", Name, Level, Strength, Agility, Intelligence, Equipment.ToString());
        }
    }
}
