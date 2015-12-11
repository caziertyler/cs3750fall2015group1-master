using System.Collections.Generic;
using UnityEngine;


namespace RPGClasses
{
    /// <summary>
    /// Contains all of the game's Gear.  Predefined Weapons, Armor, and Accessories.
    /// </summary>
    public static class GearList
    {
        // -- Handhelds -- //

        // Weapons/Shields list
        private static Dictionary<string, WeaponAbstract> WeaponShieldList = new Dictionary<string, WeaponAbstract>()
        {
          { "None", new OneHandedWeapon(0, "None", 0) },
          { "Busted Sword", new OneHandedWeapon(1,"Busted Sword", 100, PhysicalDamageBonus: 15) },
          { "Busted GreatSword", new TwoHandedWeapon(2, "Busted GreatSword", 200, PhysicalDamageBonus: 30) },
          { "Busted Shield", new Shield(3, "Busted Shield", 300,  PhysicalDefenseBonus: 15) }
        };


        // -- Armor Lists -- //

        //Head Armor list
        private static Dictionary<string, HeadArmorPiece> HeadArmorList = new Dictionary<string, HeadArmorPiece>()
        {
            {"None", new HeadArmorPiece(0, "None", 0) },
            { "Ragged Helm", new HeadArmorPiece(0, "Ragged Helm", 100,PhysicalDefenseBonus: 5) }
        };

        // Chest Armor list
        private static Dictionary<string, ChestArmorPiece> ChestArmorList = new Dictionary<string, ChestArmorPiece>()
        {
            { "None", new ChestArmorPiece(0, "None",0) },
            { "Ragged Chest", new ChestArmorPiece(0, "Ragged Chest", 100,PhysicalDefenseBonus: 5) }
        };

        // Arms Armor list
        private static Dictionary<string, ArmsArmorPiece> ArmsArmorList = new Dictionary<string, ArmsArmorPiece>()
        {
            { "None", new ArmsArmorPiece(0, "None",0) },
            { "Ragged Gloves", new ArmsArmorPiece(0, "Ragged Gloves", 100,PhysicalDefenseBonus: 5) }
        };

        // Legs Armor list
        private static Dictionary<string, LegsArmorPiece> LegsArmorList = new Dictionary<string, LegsArmorPiece>()
        {
            { "None", new LegsArmorPiece(0, "None",0) },
            { "Ragged Leggings", new LegsArmorPiece(0, "Ragged Leggings", 100,PhysicalDefenseBonus: 5) }
        };

        // Feet Armor list
        private static Dictionary<string, FeetArmorPiece> FeetArmorList = new Dictionary<string, FeetArmorPiece>()
        {
            { "None", new FeetArmorPiece(0, "None",0) },
            { "Ragged Shoes", new FeetArmorPiece(0, "Ragged Shoes", 100,PhysicalDefenseBonus: 5) }
        };


        // -- Accessories -- //

        // Amulet list
        private static Dictionary<string, Amulet> AmuletList = new Dictionary<string, Amulet>()
        {
            { "None", new Amulet(0, "None",0) },
            { "Broken Amulet", new Amulet(0, "Broken Amulet", 100,MagicDefenseBonus: 5) }
        };

        // Ring list
        private static Dictionary<string, Ring> RingList = new Dictionary<string, Ring>()
        {
            { "None", new Ring(0, "None",0) },
            { "Broken Ring", new Ring(0, "Broken Ring", 100,MagicDefenseBonus: 5) }
        };


        // -- Getters -- //

        /// <summary>
        /// Returns a list of all preset shields and weapons
        /// </summary>
        /// <returns>Dictionary<string, WeaponAbstract> WeaponShieldList</returns>
        public static Dictionary<string, WeaponAbstract> GetWeaponShieldList()
        {
            return WeaponShieldList;
        }

        /// <summary>
        /// Returns a list of all preset HeadArmorPiece GearItem objects.
        /// </summary>
        /// <returns>Dictionary<string, HeadPiece> HeadArmorList</returns>
        public static Dictionary<string, HeadArmorPiece> GetHeadPieceList()
        {
            return HeadArmorList;
        }

        /// <summary>
        /// Returns a list of all preset ChestPiece GearItem objects.
        /// </summary>
        /// <returns>Dictionary<string, ChestPiece> ChestArmorList</returns>
        public static Dictionary<string, ChestArmorPiece> GetChestPieceList()
        {
            return ChestArmorList;
        }

        /// <summary>
        /// Returns a list of all preset ArmsPiece GearItem objects.
        /// </summary>
        /// <returns>Dictionary<string, ArmsPiece> ArmsArmorList</returns>
        public static Dictionary<string, ArmsArmorPiece> GetArmsPieceList()
        {
            return ArmsArmorList;
        }

        /// <summary>
        /// Returns a list of all preset LegsPiece GearItem objects.
        /// </summary>
        /// <returns>Dictionary<string, LegsPiece> LegsArmorList</returns>
        public static Dictionary<string, LegsArmorPiece> GetLegsPieceList()
        {
            return LegsArmorList;
        }

        /// <summary>
        /// Returns a list of all preset FeetPiece GearItem objects.
        /// </summary>
        /// <returns>Dictionary<string, FeetArmorPiece> FeetArmorList</returns>
        public static Dictionary<string, FeetArmorPiece> GetFeetPieceList()
        {
            return FeetArmorList;
        }

        /// <summary>
        /// Returns a list of all preset Amulet GearItem objects.
        /// </summary>
        /// <returns>Dictionary<string, Amulet> AmuletList</returns>
        public static Dictionary<string, Amulet> GetAmuletList()
        {
            return AmuletList;
        }

        /// <summary>
        /// Returns a list of all preset LegsPiece GearItem object.
        /// </summary>
        /// <returns>Dictionary<string, Ring> RingList</returns>
        public static Dictionary<string, Ring> GetRingList()
        {
            return RingList;
        }
    }
}
