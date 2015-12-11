using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
//using UnityEditor;
//using System.Threading.Tasks;

namespace RPGClasses
{
    class Enemy : Character
    {

		public Enemy(string Name, GameObject CharacterObject, int Level = 1, Dictionary<string, Rune> Runes = null, List<Buff> Buffs = null, List<Debuff> Debuffs = null,
            int Strength = 0, int PhysicalDamage = 0, int PhysicalDefense = 0, double CriticalStrike = 0, int Hp = 0, int CurrentHp = 0, int Intelligence = 0,
            int MagicDamage = 0, int MagicDefense = 0, int FireDefense = 0, int IceDefense = 0, int ShockDefence = 0, int PoisonDefense = 0,
            int FireEvade = 0, int IceEvade = 0, int ShockEvade = 0, int PoisonEvade = 0, int AlterSuccessRate = 0, int AlterEvade = 0,
            int RunePower = 0, int CurrentRunePower = 0, int Agility = 0, int Escape = 0, int Evade = 0, int Accuracy = 0, int Speed = 0) : base(Name, CharacterObject, Level,Runes,Buffs,Debuffs,
            Strength,PhysicalDamage,PhysicalDefense,CriticalStrike,Hp,Hp,Intelligence,
            MagicDamage,MagicDefense,FireDefense, IceDefense,ShockDefence, PoisonDefense,
            FireEvade,IceEvade,ShockEvade = 0,PoisonEvade,AlterSuccessRate, AlterEvade,
            RunePower,CurrentRunePower,Agility,Escape,Evade, Accuracy,Speed)
        {
            this.CharacterObject = CharacterObject;
        }
    }

    class Wolf : Enemy
    {
        public Wolf(GameObject characterObject) : base("Wolf",characterObject)
        {
            
        }
    }
    class Skeleton : Enemy
    {
        public Skeleton() : base("Skeleton", CharacterObject: (GameObject)Resources.Load("Enemies/Skeleton", typeof(GameObject)), PhysicalDamage: 12, Hp: 125)
        {
        }
    }
}
