﻿using System.Collections.Generic;
using UnityEngine;

namespace RPGClasses
{
    public class Character
    {
		
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Dictionary<string,Rune> Runes { get; set; }
        public List<Buff> Buffs { get; set; }
        public List<Debuff> Debuffs { get; set; }
        public GameObject CharacterObject { get; set; }
		public GameObject BattleObject {get;set;}
        public BattleStats BattleStats { get; set; }
        public bool IsTurn { get; set; }
        public int Timer { get; set; }
        public GlobalMethods GlobalMethods = new GlobalMethods();

        //Strength and its subattributes
        public int Strength { get; set; }
        public int PhysicalDamage { get; set; }
        public int PhysicalDefense { get; set; }
        public double CriticalStrike { get; set; }
        public int Hp { get; set; }
        public int CurrentHp { get; set; }

        //Intelligence and its subattributes
        public int Intelligence { get; set; }
        public int MagicDamage { get; set; }
        public int MagicDefense { get; set; }
        public int FireDefense { get; set; }
        public int IceDefense { get; set; }
        public int ShockDefense { get; set; }
        public int PoisonDefense { get; set; }
        public double FireEvade { get; set; }
        public double IceEvade { get; set; }
        public double ShockEvade { get; set; }
        public double PoisonEvade { get; set; }
        public double AlterSuccessRate { get; set; }
        public double AlterEvade { get; set; }
        public int RunePower { get; set; }
        public int CurrentRunePower { get; set; }

        //Agility and its subattributes
        public int Agility { get; set; }
        public double Escape { get; set; }
        public double Evade { get; set; }
        public double Accuracy { get; set; }
        public int Speed { get; set; }

        public Character(string Name = "", GameObject CharacterObject = null, int Level = 1, Dictionary<string,Rune> Runes = null, List<Buff> Buffs = null, List<Debuff> Debuffs = null,
            int Strength = 0, int PhysicalDamage = 0, int PhysicalDefense = 0, double CriticalStrike = 0, int Hp = 0, int CurrentHp = 0, int Intelligence = 0,
            int MagicDamage = 0, int MagicDefense = 0, int FireDefense = 0, int IceDefense = 0, int ShockDefence = 0, int PoisonDefense = 0,
            int FireEvade = 0, int IceEvade = 0, int ShockEvade = 0, int PoisonEvade = 0, int AlterSuccessRate = 0, int AlterEvade = 0,
            int RunePower = 0, int CurrentRunePower = 0, int Agility = 0, int Escape = 0, int Evade = 0, int Accuracy = 0, int Speed = 0, bool IsTurn = false, int Timer = 1)
        {
            this.Name = Name;
            this.Level = Level;
			this.Runes = Runes ?? new Dictionary<string,Rune>();
            this.Buffs = Buffs ?? new List<Buff>();
            this.Debuffs = Debuffs ?? new List<Debuff>();
            this.Strength = Strength;
            this.PhysicalDamage = PhysicalDamage;
            this.PhysicalDefense = PhysicalDefense;
            this.CriticalStrike = CriticalStrike;
            this.Hp = Hp;
            this.CurrentHp = CurrentHp;
            this.Intelligence = Intelligence;
            this.MagicDamage = MagicDamage;
            this.MagicDefense = MagicDefense;
            this.FireDefense = FireDefense;
            this.IceDefense = IceDefense;
            this.ShockDefense = ShockDefense;
            this.PoisonDefense = PoisonDefense;
            this.FireEvade = FireEvade;
            this.IceEvade = IceEvade;
            this.ShockEvade = ShockEvade;
            this.PoisonEvade = PoisonEvade;
            this.AlterSuccessRate = AlterSuccessRate;
            this.AlterEvade = AlterEvade;
            this.RunePower = RunePower;
            this.CurrentRunePower = CurrentRunePower;
            this.Agility = Agility;
            this.Escape = Escape;
            this.Evade = Evade;
            this.Accuracy = Accuracy;
            this.Speed = Speed;
        }

        public void Attack(Character obj1, Character obj2)
        {
            int totalDamage = obj1.PhysicalDamage - obj2.PhysicalDefense;
            obj2.CurrentHp -= totalDamage;
            GlobalMethods.CreateDamagePopup(totalDamage, obj2.CharacterObject);
            if (obj2.CurrentHp < 0)
            {
                obj2.CurrentHp = 0;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0},\nLevel: {1},\nStrength: {2},\nAgility: {3},\nIntelligence: {4}\n",Name,Level,Strength,Agility,Intelligence);
        }
    }
}
