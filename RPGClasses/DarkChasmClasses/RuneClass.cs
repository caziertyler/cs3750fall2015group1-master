using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGClasses
{
    class RuneClass
    {

		public static List<string> getAvailableRuneClasses()
		{
			return new List<string>(){"Mage","Warrior",""};
		}

        public int Id { get; set; }
        public string Name { get; set; }

        //Strength and its subattributes
        public int StrengthBonus { get; set; }
        public int PhysicalDamageBonus { get; set; }
        public int PhysicalDefenseBonus { get; set; }
        public double CriticalStrikeBonus { get; set; }
        public int HpBonus { get; set; }

        //Intelligence and its subattributes
        public int IntelligenceBonus { get; set; }
        public int MagicDamageBonus { get; set; }
        public int MagicDefenseBonus { get; set; }
        public int FireDefenseBonus { get; set; }
        public int IceDefenseBonus { get; set; }
        public int ShockDefenseBonus { get; set; }
        public int PoisonDefenseBonus { get; set; }
        public double FireEvadeBonus { get; set; }
        public double IceEvadeBonus { get; set; }
        public double ShockEvadeBonus { get; set; }
        public double PoisonEvadeBonus { get; set; }
        public double AlterSuccessRateBonus { get; set; }
        public double AlterEvadeBonus { get; set; }
        public int RunePowerBonus { get; set; }

        //Agility and its subattributes
        public int AgilityBonus { get; set; }
        public double EscapeBonus { get; set; }
        public double EvadeBonus { get; set; }
        public double AccuracyBonus { get; set; }
        public int SpeedBonus { get; set; }

        public RuneClass()
        { }


        public RuneClass(int Id, string Name, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
           int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0.0, int HpBonus = 0, int IntelligenceBonus = 0,
           int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
           int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0.0, double IceEvadeBonus = 0.0,
           double ShockEvadeBonus = 0.0, double PoisonEvadeBonus = 0.0, double AlterSuccessRateBonus = 0.0, double AlterEvadeBonus = 0.0,
           int RunePowerBonus = 0 , int AgilityBonus = 0, double EscapeBonus = 0.0, double EvadeBonus = 0.0, double AccuracyBonus = 0.0,
           int SpeedBonus = 0)
        {
            this.Id = Id;
            this.Name = Name;
            this.StrengthBonus = StrengthBonus;
            this.PhysicalDamageBonus = PhysicalDamageBonus;
            this.PhysicalDefenseBonus = PhysicalDefenseBonus;
            this.CriticalStrikeBonus = CriticalStrikeBonus;
            this.HpBonus = HpBonus;
            this.IntelligenceBonus = IntelligenceBonus;
            this.MagicDamageBonus = MagicDamageBonus;
            this.MagicDefenseBonus = MagicDefenseBonus;
            this.FireDefenseBonus = FireDefenseBonus;
            this.IceDefenseBonus = IceDefenseBonus;
            this.ShockDefenseBonus = ShockDefenseBonus;
            this.PoisonDefenseBonus = PoisonDefenseBonus;
            this.FireEvadeBonus = FireEvadeBonus;
            this.IceEvadeBonus = IceEvadeBonus;
            this.ShockEvadeBonus = ShockEvadeBonus;
            this.PoisonEvadeBonus = PoisonEvadeBonus;
            this.AlterSuccessRateBonus = AlterSuccessRateBonus;
            this.AlterEvadeBonus = AlterEvadeBonus;
            this.RunePowerBonus = RunePowerBonus;
            this.AgilityBonus = AgilityBonus;
            this.EscapeBonus = EscapeBonus;
            this.EvadeBonus = EvadeBonus;
            this.AccuracyBonus = AccuracyBonus;
            this.SpeedBonus = SpeedBonus;
        }
    }
}
