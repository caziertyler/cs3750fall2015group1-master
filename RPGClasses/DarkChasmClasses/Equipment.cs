using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGClasses
{
    class Equipment
    {
        public Head Head 	{ get; set; }
        public Chest Chest 	 { get; set; }
        public Arm Arm 	  { get; set; }
		public Legs Legs 	   { get; set; }
        public Feet Feet 	    { get; set; }
		public Weapon MainHand 	     { get; set; }
		public Weapon OffHand 	    { get; set; }
        public Amulet Amulet 	   { get; set; }
        public Ring Ring1 	  { get; set; }
        public Ring Ring2 	{ get; set; }

        public EquipmentList Equip = new EquipmentList();

        //Strength and its subattributes
        public int StrengthBonus
        {
            get
            {
                return Head.StrengthBonus + Chest.StrengthBonus + Arm.StrengthBonus + Legs.StrengthBonus + MainHand.StrengthBonus
                + OffHand.StrengthBonus + Feet.StrengthBonus + Amulet.StrengthBonus + Ring1.StrengthBonus + Ring2.StrengthBonus;
            }
        }

        public int PhysicalDamageBonus
        {
            get
            {
                return Head.PhysicalDamageBonus + Chest.PhysicalDamageBonus + Arm.PhysicalDamageBonus + Legs.PhysicalDamageBonus + MainHand.PhysicalDamageBonus
                + OffHand.PhysicalDamageBonus + Feet.PhysicalDamageBonus + Amulet.PhysicalDamageBonus + Ring1.PhysicalDamageBonus + Ring2.PhysicalDamageBonus;
            }
        }
        public int PhysicalDefenseBonus
        {
            get
            {
                return Head.PhysicalDefenseBonus + Chest.PhysicalDefenseBonus + Arm.PhysicalDefenseBonus + Legs.PhysicalDefenseBonus + MainHand.PhysicalDefenseBonus
                + OffHand.PhysicalDefenseBonus + Feet.PhysicalDefenseBonus + Amulet.PhysicalDefenseBonus + Ring1.PhysicalDefenseBonus + Ring2.PhysicalDefenseBonus;
            }
        }
        public double CriticalStrikeBonus
        {
            get
            {
                return Head.CriticalStrikeBonus + Chest.CriticalStrikeBonus + Arm.CriticalStrikeBonus + Legs.CriticalStrikeBonus + MainHand.CriticalStrikeBonus
                + OffHand.CriticalStrikeBonus + Feet.CriticalStrikeBonus + Amulet.CriticalStrikeBonus + Ring1.CriticalStrikeBonus + Ring2.CriticalStrikeBonus;
            }
        }
        public int HpBonus
        {
            get
            {
                return Head.HpBonus + Chest.HpBonus + Arm.HpBonus + Legs.HpBonus + MainHand.HpBonus
                + OffHand.HpBonus + Feet.HpBonus + Amulet.HpBonus + Ring1.HpBonus + Ring2.HpBonus;
            }
        }

        //Intelligence and its subattributes
        public int IntelligenceBonus
        {
            get
            {
                return Head.IntelligenceBonus + Chest.IntelligenceBonus + Arm.IntelligenceBonus + Legs.IntelligenceBonus + MainHand.IntelligenceBonus
                + OffHand.IntelligenceBonus + Feet.IntelligenceBonus + Amulet.IntelligenceBonus + Ring1.IntelligenceBonus + Ring2.IntelligenceBonus;
            }
        }
        public int MagicDamageBonus
        {
            get
            {
                return Head.MagicDamageBonus + Chest.MagicDamageBonus + Arm.MagicDamageBonus + Legs.MagicDamageBonus + MainHand.MagicDamageBonus
                + OffHand.MagicDamageBonus + Feet.MagicDamageBonus + Amulet.MagicDamageBonus + Ring1.MagicDamageBonus + Ring2.MagicDamageBonus;
            }
        }
        public int MagicDefenseBonus
        {
            get
            {
                return Head.MagicDefenseBonus + Chest.MagicDefenseBonus + Arm.MagicDefenseBonus + Legs.MagicDefenseBonus + MainHand.MagicDefenseBonus
                + OffHand.MagicDefenseBonus + Feet.MagicDefenseBonus + Amulet.MagicDefenseBonus + Ring1.MagicDefenseBonus + Ring2.MagicDefenseBonus;
            }
        }
        public int FireDefenseBonus
        {
            get
            {
                return Head.FireDefenseBonus + Chest.FireDefenseBonus + Arm.FireDefenseBonus + Legs.FireDefenseBonus + MainHand.FireDefenseBonus
                + OffHand.FireDefenseBonus + Feet.FireDefenseBonus + Amulet.FireDefenseBonus + Ring1.FireDefenseBonus + Ring2.FireDefenseBonus;
            }
        }
        public int IceDefenseBonus
        {
            get
            {
                return Head.IceDefenseBonus + Chest.IceDefenseBonus + Arm.IceDefenseBonus + Legs.IceDefenseBonus + MainHand.IceDefenseBonus
                + OffHand.IceDefenseBonus + Feet.IceDefenseBonus + Amulet.IceDefenseBonus + Ring1.IceDefenseBonus + Ring2.IceDefenseBonus;
            }
        }
        public int ShockDefenseBonus
        {
            get
            {
                return Head.ShockDefenseBonus + Chest.ShockDefenseBonus + Arm.ShockDefenseBonus + Legs.ShockDefenseBonus + MainHand.ShockDefenseBonus
                + OffHand.ShockDefenseBonus + Feet.ShockDefenseBonus + Amulet.ShockDefenseBonus + Ring1.ShockDefenseBonus + Ring2.ShockDefenseBonus;
            }
        }
        public int PoisonDefenseBonus
        {
            get
            {
                return Head.PoisonDefenseBonus + Chest.PoisonDefenseBonus + Arm.PoisonDefenseBonus + Legs.PoisonDefenseBonus + MainHand.PoisonDefenseBonus
                + OffHand.PoisonDefenseBonus + Feet.PoisonDefenseBonus + Amulet.PoisonDefenseBonus + Ring1.PoisonDefenseBonus + Ring2.PoisonDefenseBonus;
            }
        }
        public double FireEvadeBonus
        {
            get
            {
                return Head.FireEvadeBonus + Chest.FireEvadeBonus + Arm.FireEvadeBonus + Legs.FireEvadeBonus + MainHand.FireEvadeBonus
                + OffHand.FireEvadeBonus + Feet.FireEvadeBonus + Amulet.FireEvadeBonus + Ring1.FireEvadeBonus + Ring2.FireEvadeBonus;
            }
        }
        public double IceEvadeBonus
        {
            get
            {
                return Head.IceEvadeBonus + Chest.IceEvadeBonus + Arm.IceEvadeBonus + Legs.IceEvadeBonus + MainHand.IceEvadeBonus
                + OffHand.IceEvadeBonus + Feet.IceEvadeBonus + Amulet.IceEvadeBonus + Ring1.IceEvadeBonus + Ring2.IceEvadeBonus;
            }
        }
        public double ShockEvadeBonus
        {
            get
            {
                return Head.ShockEvadeBonus + Chest.ShockEvadeBonus + Arm.ShockEvadeBonus + Legs.ShockEvadeBonus + MainHand.ShockEvadeBonus
                + OffHand.ShockEvadeBonus + Feet.ShockEvadeBonus + Amulet.ShockEvadeBonus + Ring1.ShockEvadeBonus + Ring2.ShockEvadeBonus;
            }
        }
        public double PoisonEvadeBonus
        {
            get
            {
                return Head.PoisonEvadeBonus + Chest.PoisonEvadeBonus + Arm.PoisonEvadeBonus + Legs.PoisonEvadeBonus + MainHand.PoisonEvadeBonus
                + OffHand.PoisonEvadeBonus + Feet.PoisonEvadeBonus + Amulet.PoisonEvadeBonus + Ring1.PoisonEvadeBonus + Ring2.PoisonEvadeBonus;
            }
        }
        public double AlterSuccessRateBonus
        {
            get
            {
                return Head.AlterSuccessRateBonus + Chest.AlterSuccessRateBonus + Arm.AlterSuccessRateBonus + Legs.AlterSuccessRateBonus + MainHand.AlterSuccessRateBonus
                + OffHand.AlterSuccessRateBonus + Feet.AlterSuccessRateBonus + Amulet.AlterSuccessRateBonus + Ring1.AlterSuccessRateBonus + Ring2.AlterSuccessRateBonus;
            }
        }
        public double AlterEvadeBonus
        {
            get
            {
                return Head.AlterEvadeBonus + Chest.AlterEvadeBonus + Arm.AlterEvadeBonus + Legs.AlterEvadeBonus + MainHand.AlterEvadeBonus
                + OffHand.AlterEvadeBonus + Feet.AlterEvadeBonus + Amulet.AlterEvadeBonus + Ring1.AlterEvadeBonus + Ring2.AlterEvadeBonus;
            }
        }
        public int RunePowerBonus
        {
            get
            {
                return Head.RunePowerBonus + Chest.RunePowerBonus + Arm.RunePowerBonus + Legs.RunePowerBonus + MainHand.RunePowerBonus
                + OffHand.RunePowerBonus + Feet.RunePowerBonus + Amulet.RunePowerBonus + Ring1.RunePowerBonus + Ring2.RunePowerBonus;
            }
        }

        //Agility and its subattributes
        public int AgilityBonus
        {
            get
            {
                return Head.AgilityBonus + Chest.AgilityBonus + Arm.AgilityBonus + Legs.AgilityBonus + MainHand.AgilityBonus
                + OffHand.AgilityBonus + Feet.AgilityBonus + Amulet.AgilityBonus + Ring1.AgilityBonus + Ring2.AgilityBonus;
            }
        }
        public double EscapeBonus
        {
            get
            {
                return Head.EscapeBonus + Chest.EscapeBonus + Arm.EscapeBonus + Legs.EscapeBonus + MainHand.EscapeBonus
                + OffHand.EscapeBonus + Feet.EscapeBonus + Amulet.EscapeBonus + Ring1.EscapeBonus + Ring2.EscapeBonus;
            }
        }
        public double EvadeBonus
        {
            get
            {
                return Head.EvadeBonus + Chest.EvadeBonus + Arm.EvadeBonus + Legs.EvadeBonus + MainHand.EvadeBonus
                + OffHand.EvadeBonus + Feet.EvadeBonus + Amulet.EvadeBonus + Ring1.EvadeBonus + Ring2.EvadeBonus;
            }
        }
        public double AccuracyBonus
        {
            get
            {
                return Head.AccuracyBonus + Chest.AccuracyBonus + Arm.AccuracyBonus + Legs.AccuracyBonus + MainHand.AccuracyBonus
                + OffHand.AccuracyBonus + Feet.AccuracyBonus + Amulet.AccuracyBonus + Ring1.AccuracyBonus + Ring2.AccuracyBonus;
            }
        }
        public int SpeedBonus
        {
            get
            {
                return Head.SpeedBonus + Chest.SpeedBonus + Arm.SpeedBonus + Legs.SpeedBonus + MainHand.SpeedBonus
                + OffHand.SpeedBonus + Feet.SpeedBonus + Amulet.SpeedBonus + Ring1.SpeedBonus + Ring2.SpeedBonus;
            }
        }

        //public Equipment( Gear Head, Gear Chest,Gear Arm,Gear Legs,Gear Feet, Gear Amulet, Gear Ring1, Gear Ring2, int StrengthBonus, int PhysicalDamageBonus,
        //    int PhysicalDefenseBonus, double CriticalStrikeBonus, int HpBonus, int IntelligenceBonus,
        //    int MagicDamageBonus, int MagicDefenseBonus, int FireDefenseBonus, int IceDefenseBonus,
        //    int ShockDefenseBonus, int PoisonDefenseBonus, double FireEvadeBonus, double IceEvadeBonus,
        //    double ShockEvadeBonus, double PoisonEvadeBonus, double AlterSuccessRateBonus, double AlterEvadeBonus,
        //    int RunePowerBonus, int AgilityBonus, double EscapeBonus, double EvadeBonus, double AccuracyBonus,
        //    int SpeedBonus)
        public Equipment()
        {
            this.Head = Equip.equipHead("Ragged Helm");
            this.Chest = Equip.equipChest("None");
            this.Arm = Equip.equipArm("None");
            this.Legs = Equip.equipLegs("None");
            this.Feet = Equip.equipFeet("None");
            this.MainHand = Equip.equipWeapon(this, "None");
            this.OffHand = Equip.equipWeapon(this, "None");
            this.Amulet = Equip.equipAmulet("None");
            this.Ring1 = Equip.equipRing("None");
            this.Ring2 = Equip.equipRing("None");
        }
        

		public override string ToString ()
		{
			return string.Format ("[Equipment: Head={0}, Chest={1}, Arm={2}, Legs={3}, Feet={4}, LHand={5}, RHand={6}, Amulet={7}, Ring1={8}, Ring2={9}, StrengthBonus={10}, PhysicalDamageBonus={11}, PhysicalDefenseBonus={12}, CriticalStrikeBonus={13}, HpBonus={14}, IntelligenceBonus={15}, MagicDamageBonus={16}, MagicDefenseBonus={17}, FireDefenseBonus={18}, IceDefenseBonus={19}, ShockDefenseBonus={20}, PoisonDefenseBonus={21}, FireEvadeBonus={22}, IceEvadeBonus={23}, ShockEvadeBonus={24}, PoisonEvadeBonus={25}, AlterSuccessRateBonus={26}, AlterEvadeBonus={27}, RunePowerBonus={28}, AgilityBonus={29}, EscapeBonus={30}, EvadeBonus={31}, AccuracyBonus={32}, SpeedBonus={33}]", Head, Chest, Arm, Legs, Feet, MainHand, OffHand, Amulet, Ring1, Ring2, StrengthBonus, PhysicalDamageBonus, PhysicalDefenseBonus, CriticalStrikeBonus, HpBonus, IntelligenceBonus, MagicDamageBonus, MagicDefenseBonus, FireDefenseBonus, IceDefenseBonus, ShockDefenseBonus, PoisonDefenseBonus, FireEvadeBonus, IceEvadeBonus, ShockEvadeBonus, PoisonEvadeBonus, AlterSuccessRateBonus, AlterEvadeBonus, RunePowerBonus, AgilityBonus, EscapeBonus, EvadeBonus, AccuracyBonus, SpeedBonus);
		}

		/*
        public override string ToString()
        {
            return string.Format("\nHead: {0},\nChest: {1},\nArm: {2},\nLegs: {3},\nFeet: {4},\nAmulet: {5},\nRing1: {6},\nRing2: {7}", Head.Name, Chest.Name, Arm.Name, Legs.Name, Feet.Name, Amulet.Name, Ring1.Name, Ring2.Name);
        }*/
    }

}
