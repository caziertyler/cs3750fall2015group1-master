using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGClasses
{
    //* In from of field means it is required
    //Base class(* int Id, * string Name, int StrengthBonus, int PhysicalDamageBonus,
    //int PhysicalDefenseBonus, double CriticalStrikeBonus, int HpBonus, int IntelligenceBonus,
    //   int MagicDamageBonus, int MagicDefenseBonus, int FireDefenseBonus, int IceDefenseBonus,
    //   int ShockDefenseBonus, int PoisonDefenseBonus, double FireEvadeBonus, double IceEvadeBonus,
    //   double ShockEvadeBonus, double PoisonEvadeBonus, double AlterSuccessRateBonus, double AlterEvadeBonus,
    //   int RunePowerBonus, int AgilityBonus, double EscapeBonus, double EvadeBonus, double AccuracyBonus,
    //   int SpeedBonus)
    class Squire : RuneClass
    {
        public Squire() : base(0, "Squire") { }
    }

    class Warrior : RuneClass
    {
        public Warrior() : base
            (1, 
            "Warrior", 
            StrengthBonus: 5, 
            PhysicalDamageBonus: 10, 
            PhysicalDefenseBonus: 10, 
            CriticalStrikeBonus: .5, 
            HpBonus: 150,
            RunePowerBonus: 50) { }
		
    }

    class Mage : RuneClass
    {
        public Mage() : base
            (2, 
            "Mage", 
            HpBonus: 50, 
            IntelligenceBonus: 5, 
            MagicDamageBonus: 10, 
            MagicDefenseBonus: 10, 
            RunePowerBonus: 150) { }
    }

    class Thief : RuneClass
    {
        public Thief() : base
            (3, 
            "Thief", 
            HpBonus: 100, 
            AgilityBonus: 5, 
            EscapeBonus: 10, 
            EvadeBonus: 10, 
            AccuracyBonus: 5, 
            SpeedBonus: 10, 
            RunePowerBonus: 50) { }
        
    }
}
