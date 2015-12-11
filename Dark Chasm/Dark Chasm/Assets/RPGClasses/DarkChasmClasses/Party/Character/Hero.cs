using System;
using System.Collections.Generic;
using UnityEngine;

namespace RPGClasses
{
    /// <summary>
    /// 
    /// </summary>
    public class Hero : Character
    {
        public int Experience { get; set; }
        public List<RuneClassList> RuneClasses { get; set; }
        public Equipment Equipment { get; set; }
        public RuneClassList RuneClass { get; set; }
        public enum Hand { Main, Off }

        public Hero(string Name, GameObject CharacterObject, int Timer = 1) : base(Name, CharacterObject, 1, new Dictionary<string,Rune>(), new List<Buff>(), new List<Debuff>(), 1, 25, 1, 1.0, 350, 350, 1, 30, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 150, 150, 1, 1, 1, 1, 1, false, Timer)
        {
            this.Name = Name;
            this.CharacterObject = CharacterObject;
            this.RuneClasses = new List<RuneClassList>();
            this.RuneClasses.Add(new Squire());
            this.RuneClass = new Squire();
            this.Equipment = new Equipment();
        }

        public Hero(string Name, GameObject CharacterObject, int Experience, List<RuneClassList> RuneClasses, Equipment Equipment, RuneClassList RuneClass) : base(Name,CharacterObject,1,new Dictionary<string,Rune>(),new List<Buff>(),new List<Debuff>(),1,25,1,1.0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,150,1,1,1,1,1,1)
        {
            this.Name = Name;
            this.CharacterObject = CharacterObject;
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


			if (!Runes.ContainsKey(rune.Name))
            {
                Runes.Add(rune.Name,rune);
            }
        }
            

        public override string ToString()
        {
            return string.Format("Name: {0},\nLevel: {1},\nStrength: {2},\nAgility: {3},\nIntelligence: {4}\nEquipment: {5}", Name, Level, Strength, Agility, Intelligence, Equipment.ToString());
        }
    }
}
