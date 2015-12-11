using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGClasses
{
    class Enemy : Character
    {

        public Enemy(string Name = "", int Level = 1, List<Rune> Runes = null, List<Buff> Buffs = null, List<Debuff> Debuffs = null,
            int Strength = 0, int PhysicalDamage = 0, int PhysicalDefense = 0, double CriticalStrike = 0, int Hp = 0, int CurHp = 0, int Intelligence = 0,
            int MagicDamage = 0, int MagicDefense = 0, int FireDefense = 0, int IceDefense = 0, int ShockDefence = 0, int PoisonDefense = 0,
            int FireEvade = 0, int IceEvade = 0, int ShockEvade = 0, int PoisonEvade = 0, int AlterSuccessRate = 0, int AlterEvade = 0,
            int RunePower = 0, int CurRunePower = 0, int Agility = 0, int Escape = 0, int Evade = 0, int Accuracy = 0, int Speed = 0) : base()
        { }
    }

    class Wolf : Enemy
    {
        public Wolf() : base()
        {
        	
        }
    }
}
