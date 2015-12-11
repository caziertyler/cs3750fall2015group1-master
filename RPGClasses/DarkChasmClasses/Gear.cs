using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGClasses
{
    class Gear
    {
        private int Id { get; set; }
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

        public Gear()
        {

        }
        public Gear(int Id, string Name, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
            int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0, int IntelligenceBonus = 0,
            int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
            int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
            double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0, double AlterEvadeBonus = 0,
            int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0, double EvadeBonus = 0, double AccuracyBonus = 0,
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




    class EquipmentList
    {

        //Weapons/Shields list
        Dictionary<string, Weapon> WeaponList = new Dictionary<string, Weapon>()
        {
          { "None", new Weapon(0, "None", WeaponType.OneHanded) },
          { "Busted Sword", new Weapon(1, "Busted Sword", WeaponType.OneHanded, PhysicalDamageBonus: 15) },
          { "Busted GreatSword", new Weapon(2, "Busted GreatSword", WeaponType.TwoHanded, PhysicalDamageBonus: 30) },
          { "Busted Shield", new Weapon(3, "Busted Shield", WeaponType.Shield, PhysicalDefenseBonus: 15) }
        };
        //Head list
        Dictionary<string, Head> HeadList = new Dictionary<string, Head>()
        {
            {"None", new Head(0, "None") },
            { "Ragged Helm", new Head(0, "Ragged Helm", PhysicalDefenseBonus: 5) }
        };

        //Chest list
        Dictionary<string, Chest> ChestList = new Dictionary<string, Chest>()
        {
            { "None", new Chest(0, "None") },
            { "Ragged Chest", new Chest(0, "Ragged Chest", PhysicalDefenseBonus: 5) }
        };

        //Arm list
        Dictionary<string, Arm> ArmList = new Dictionary<string, Arm>()
        {
            { "None", new Arm(0, "None") },
            { "Ragged Gloves", new Arm(0, "Ragged Gloves", PhysicalDefenseBonus: 5) }
        };

        //Legs list
        Dictionary<string, Legs> LegsList = new Dictionary<string, Legs>()
        {
            { "None", new Legs(0, "None") },
            { "Ragged Leggings", new Legs(0, "Ragged Leggings", PhysicalDefenseBonus: 5) }
        };

        //Feet list
        Dictionary<string, Feet> FeetList = new Dictionary<string, Feet>()
        {
            { "None", new Feet(0, "None") },
            { "Ragged Shoes", new Feet(0, "Ragged Shoes", PhysicalDefenseBonus: 5) }
        };

        //Amulet list
        Dictionary<string, Amulet> AmuletList = new Dictionary<string, Amulet>()
        {
            { "None", new Amulet(0, "None") },
            { "Broken Amulet", new Amulet(0, "Broken Amulet", MagicDefenseBonus: 5) }
        };

        //Ring list
        Dictionary<string, Ring> RingList = new Dictionary<string, Ring>()
        {
            { "None", new Ring(0, "None") },
            { "Broken Ring", new Ring(0, "Broken Ring", MagicDefenseBonus: 5) }
        };


        public EquipmentList()
        { }

        public Weapon equipWeapon(Equipment equipment, string key)
        {
            Weapon newWeapon = WeaponList[key];

            //Weapon being equipped is TwoHanded Weapon
            if (newWeapon.WeaponType == WeaponType.TwoHanded)
            {
                equipment.MainHand = WeaponList["None"];
                equipment.OffHand = WeaponList["None"];
                return WeaponList[key];
            }
            else if (newWeapon.WeaponType == WeaponType.Shield)
            {
                if (equipment.MainHand.WeaponType == WeaponType.TwoHanded || equipment.OffHand.WeaponType == WeaponType.TwoHanded)
                {
                    equipment.MainHand = WeaponList["None"];
                    equipment.OffHand = WeaponList["None"];
                    return WeaponList[key];
                }
                else if (equipment.MainHand.WeaponType == WeaponType.Shield)
                {
                    equipment.MainHand = WeaponList["None"];
                    return WeaponList[key];
                }
                else if (equipment.OffHand.WeaponType == WeaponType.Shield)
                {
                    equipment.OffHand = WeaponList["None"];
                    return WeaponList[key];
                }
                else
                {
                    return WeaponList[key];
                }
            }
            else
            {
                return WeaponList[key];
            }
        }

        public Head equipHead(string key)
        {
            Head test = HeadList["Ragged Helm"];
            return HeadList[key];
        }

        public Chest equipChest(string key)
        {
            return ChestList[key];
        }

        public Arm equipArm(string key)
        {
            return ArmList[key];
        }

        public Legs equipLegs(string key)
        {
            return LegsList[key];
        }

        public Feet equipFeet(string key)
        {
            return FeetList[key];
        }

        public Amulet equipAmulet(string key)
        {
            return AmuletList[key];
        }

        public Ring equipRing(string key)
        {
            return RingList[key];
        }
    }

    class Weapon : Gear
    {
        public WeaponType WeaponType;
        public Weapon(int Id, string Name, WeaponType WeaponType, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
            int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0, int IntelligenceBonus = 0,
            int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
            int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
            double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0, double AlterEvadeBonus = 0,
            int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0, double EvadeBonus = 0, double AccuracyBonus = 0,
            int SpeedBonus = 0) : base()
        {
            this.WeaponType = WeaponType;
        }
    }

    //class Shield : Gear
    //{

    //    public Shield(int Id, string Name, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
    //        int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0, int IntelligenceBonus = 0,
    //        int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
    //        int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
    //        double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0, double AlterEvadeBonus = 0,
    //        int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0, double EvadeBonus = 0, double AccuracyBonus = 0,
    //        int SpeedBonus = 0) : base()
    //    { }
    //}

    class Head : Gear
    {
        public Head(int Id, string Name, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
            int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0, int IntelligenceBonus = 0,
            int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
            int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
            double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0, double AlterEvadeBonus = 0,
            int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0, double EvadeBonus = 0, double AccuracyBonus = 0,
            int SpeedBonus = 0) : base(Id, Name)
        {
        }
    }


    class Chest : Gear
    {
        public Chest(int Id, string Name, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
            int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0, int IntelligenceBonus = 0,
            int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
            int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
            double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0, double AlterEvadeBonus = 0,
            int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0, double EvadeBonus = 0, double AccuracyBonus = 0,
            int SpeedBonus = 0)
        { }
    }

    class Arm : Gear
    {
        public Arm(int Id, string Name, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
            int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0, int IntelligenceBonus = 0,
            int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
            int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
            double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0, double AlterEvadeBonus = 0,
            int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0, double EvadeBonus = 0, double AccuracyBonus = 0,
            int SpeedBonus = 0)
        { }
    }

    class Legs : Gear
    {
        public Legs(int Id, string Name, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
            int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0, int IntelligenceBonus = 0,
            int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
            int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
            double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0, double AlterEvadeBonus = 0,
            int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0, double EvadeBonus = 0, double AccuracyBonus = 0,
            int SpeedBonus = 0) : base()
        { }
    }

    class Feet : Gear
    {
        public Feet(int Id, string Name, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
            int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0, int IntelligenceBonus = 0,
            int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
            int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
            double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0, double AlterEvadeBonus = 0,
            int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0, double EvadeBonus = 0, double AccuracyBonus = 0,
            int SpeedBonus = 0) : base()
        { }
    }

    class Amulet : Gear
    {

        public Amulet(int Id, string Name, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
            int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0, int IntelligenceBonus = 0,
            int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
            int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
            double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0, double AlterEvadeBonus = 0,
            int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0, double EvadeBonus = 0, double AccuracyBonus = 0,
            int SpeedBonus = 0) : base()
        { }
    }

    class Ring : Gear
    {
        public Ring(int Id, string Name, int StrengthBonus = 0, int PhysicalDamageBonus = 0,
            int PhysicalDefenseBonus = 0, double CriticalStrikeBonus = 0, int HpBonus = 0, int IntelligenceBonus = 0,
            int MagicDamageBonus = 0, int MagicDefenseBonus = 0, int FireDefenseBonus = 0, int IceDefenseBonus = 0,
            int ShockDefenseBonus = 0, int PoisonDefenseBonus = 0, double FireEvadeBonus = 0, double IceEvadeBonus = 0,
            double ShockEvadeBonus = 0, double PoisonEvadeBonus = 0, double AlterSuccessRateBonus = 0, double AlterEvadeBonus = 0,
            int RunePowerBonus = 0, int AgilityBonus = 0, double EscapeBonus = 0, double EvadeBonus = 0, double AccuracyBonus = 0,
            int SpeedBonus = 0) : base()
        { }
    }
    enum WeaponType
    {
        TwoHanded,
        OneHanded,
        Shield
    }
}