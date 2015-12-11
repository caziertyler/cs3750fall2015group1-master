using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor;

namespace RPGClasses
{
    public abstract class Rune
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Value { get; set; }
        public GameObject RuneObject { get; set; }
        public int PhysicalDamage { get; set; }
        public int MagicDamage { get; set; }
        public int RunePowerCost { get; set; }
        public bool IsAOE { get; set; }
        public List<string> RuneClasses { get; set; }
        public GlobalMethods GlobalMethods = new GlobalMethods();
        
        public Rune(int Id, string Name, int Value, GameObject RuneObject ,int PhysicalDamage, int MagicDamage, int RunePowerCost, bool IsAOE, List<string> RuneClasses)
        {
            this.Id = Id;
            this.Name = Name;
            this.Value = Value;
            this.RuneObject = RuneObject;
            this.PhysicalDamage = PhysicalDamage;
            this.MagicDamage = MagicDamage;
            this.RunePowerCost = RunePowerCost;
            this.IsAOE = IsAOE;
            this.RuneClasses = RuneClasses;
        }

        public abstract void castRune(Character obj1, Character obj2);
    }

    public class Fire : Rune
    {
        public static List<string> UsableClasses = new List<string>() { "Squire", "Mage" };
        // id, name, cost, gameobject, physicalDamage, magicDamage, runePowerCost, isAOE
        public Fire() : base(0, "Fire", 500, (GameObject)Resources.Load("Abilities/Fire", typeof(GameObject)), 0, 26, 25, false, UsableClasses) { }

        public override void castRune(Character obj1, Character obj2)
        {
                obj1.CurrentRunePower -= RunePowerCost;
                int totalDamage = obj1.MagicDamage + this.MagicDamage;
                obj2.CurrentHp -= totalDamage;
                GameObject fire = GameObject.Instantiate(RuneObject, Vector3.zero, Quaternion.identity) as GameObject;
                fire.tag = "Fire";
                fire.transform.position = obj2.CharacterObject.transform.position;
                GlobalMethods.CreateDamagePopup(totalDamage, fire);
                Debug.Log(obj1.Name + " shoots fire ball at " + obj2.Name + " for " + totalDamage + " damage");
                if (obj2.CurrentHp < 0)
                {
                    obj2.CurrentHp = 0;
                }
                Debug.Log(obj2.Name + " has " + obj2.CurrentHp + " HP remaining");
        }
    }
    
    class Ice : Rune
    {
        public static List<string> UsableClasses = new List<string>() { "Squire", "Mage" };
        // id, name, physicaldamage, magicdamage, runepowercost, isaoe
        public Ice() : base(0, "Ice", 500, (GameObject)Resources.Load("Abilities/Ice", typeof(GameObject)), 0, 25, 25, false, UsableClasses) { }

        public override void castRune(Character obj1, Character obj2)
        {
            obj1.CurrentRunePower -= RunePowerCost;
            int totalDamage = obj1.MagicDamage + this.MagicDamage;
            obj2.CurrentHp -= totalDamage;
            GameObject ice = GameObject.Instantiate(RuneObject, Vector3.zero, Quaternion.identity) as GameObject;
            ice.tag = "Ice";
            ice.transform.position = obj2.CharacterObject.transform.position;
            GlobalMethods.CreateDamagePopup(totalDamage, ice);
            Debug.Log(obj1.Name + " shoots Ice blast at " + obj2.Name + " for " + totalDamage + " damage");
            if (obj2.CurrentHp < 0)
            {
                obj2.CurrentHp = 0;
            }
            Debug.Log(obj2.Name + " has " + obj2.CurrentHp + " HP remaining");
        }
    }

    class Stone : Rune
    {

        public static List<string> UsableClasses = new List<string>() { "Squire", "Mage" };
        // id, name, physicaldamage, magicdamage, runepowercost, isaoe
        public Stone() : base(0, "Stone", 500, (GameObject)Resources.Load("Abilities/Stone", typeof(GameObject)), 0, 24, 25, false, UsableClasses) { }

        public override void castRune(Character obj1, Character obj2)
        {
            obj1.CurrentRunePower -= RunePowerCost;
            int totalDamage = obj1.MagicDamage + this.MagicDamage;
            obj2.CurrentHp -= totalDamage;
            GameObject stone = GameObject.Instantiate(RuneObject, Vector3.zero, Quaternion.identity) as GameObject;
            stone.tag = "Stone";
            stone.transform.position = obj2.CharacterObject.transform.position;
            GlobalMethods.CreateDamagePopup(totalDamage, stone);
            Debug.Log(obj1.Name + " shoots Ice blast at " + obj2.Name + " for " + totalDamage + " damage");
            if (obj2.CurrentHp < 0)
            {
                obj2.CurrentHp = 0;
            }
            Debug.Log(obj2.Name + " has " + obj2.CurrentHp + " HP remaining");
        }
    }

    class Lightning : Rune
    {
        public static List<string> UsableClasses = new List<string>() { "Squire", "Mage" };
        // id, name, physicaldamage, magicdamage, runepowercost, isaoe
        public Lightning() : base(0, "Lightning", 500, (GameObject)Resources.Load("Abilities/Lightning", typeof(GameObject)), 0, 23, 25, false, UsableClasses) { }

        public override void castRune(Character obj1, Character obj2)
        {
            obj1.CurrentRunePower -= RunePowerCost;
            int totalDamage = obj1.MagicDamage + this.MagicDamage;
            obj2.CurrentHp -= totalDamage;
            GameObject lightning = GameObject.Instantiate(RuneObject, Vector3.zero, Quaternion.identity) as GameObject;
            lightning.tag = "Lightning";
            lightning.transform.position = obj2.CharacterObject.transform.position;
            GlobalMethods.CreateDamagePopup(totalDamage, lightning);
            Debug.Log(obj1.Name + " shoots Ice blast at " + obj2.Name + " for " + totalDamage + " damage");
            if (obj2.CurrentHp < 0)
            {
                obj2.CurrentHp = 0;
            }
            Debug.Log(obj2.Name + " has " + obj2.CurrentHp + " HP remaining");
        }
    }
    //class Poison : Rune
    //{
    //    public static List<RuneClass> UsableClasses = new List<RuneClass>() { };
    //    id, name, physicalDamage, magicDamage, runePowerCost, isAOE
    //    public Poison() : base(0, "poison", 0, 25, 25, false, UsableClasses) { }

    //    public override void specialAbility(Character obj1, Character obj2)
    //    {
    //        Console.WriteLine("reptile spits poison");
    //    }
    //}

    //class Cure : Rune
    //{
    //    public static List<string> UsableClasses = new List<string>() { };
    //    // id, name, physicalDamage, magicDamage, runePowerCost, isAOE
    //    public Cure() : base(0, "Cure", 0, 100, 25, false, UsableClasses) { }

    //    public override void castRune(Character obj1, Character obj2)
    //    {
    //        int totalHeal = obj1.MagicDamage + this.MagicDamage;
    //        obj1.CurRunePower -= RunePowerCost;
    //        obj2.CurHp += totalHeal;
    //        Console.WriteLine(obj1.Name + " sends a healing wave at " + obj2.Name + " for " + totalHeal + " health");
    //        if (obj2.CurHp > obj2.Hp)
    //        {
    //            obj2.CurHp = obj2.Hp;
    //        }
    //        Console.WriteLine(obj2.Name + " has " + obj2.CurHp + " HP remaining");
    //    }
    //}
}
