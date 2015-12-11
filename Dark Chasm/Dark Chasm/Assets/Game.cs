using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;
/*
  Game class will contain everything the game needs
  It just has a character for now
*/
namespace RPGClasses
{
    public class GameAsset
    {
        public Character character { get; set; }
        public GameObject gameObject { get; set; }

        public GameAsset(Character character, GameObject gameObject)
        {
            this.character = character;
            this.gameObject = gameObject;
        }
    }
    public class Game
    {
		public int id;
		public Party party;
        public Party enemies;
		public int chapter;
		public Transform location;
        public GameObject mainCharacter;

        public Game()
        {
            party = new Party();
            enemies = new Party();
            mainCharacter = GameObject.Instantiate((GameObject)Resources.Load("Player/MainCharacter", typeof(GameObject)), new Vector3(223,-530), Quaternion.identity) as GameObject;

            //Hero tidus = 
            //tidus.addRune(new Fire());
            Hero Tidus = new Hero("Tidus", null);
            Tidus.addRune(new Fire());
            Tidus.addRune(new Ice());
            Tidus.addRune(new Lightning());
            Tidus.addRune(new Stone());

            Hero Marcus = new Hero("Marcus",null);
            Marcus.addRune(new Fire());
            Marcus.addRune(new Ice());
            Marcus.addRune(new Lightning());
            Marcus.addRune(new Stone());

            Hero Lucas = new Hero("Lucas", null);
            Lucas.addRune(new Fire());
            Lucas.addRune(new Ice());
            Lucas.addRune(new Lightning());
            Lucas.addRune(new Stone());

            Hero Pucas = new Hero("Pucas", null);
            Pucas.addRune(new Fire());
            Pucas.addRune(new Ice());
            Pucas.addRune(new Lightning());
            Pucas.addRune(new Stone());

            party.Characters.Add(Tidus);
            party.Characters.Add(Marcus);
            party.Characters.Add(Lucas);
            party.Characters.Add(Pucas);

            //Enemy wolf = new Wolf(GameObject.Find)


        }

    }

    /* 
      this static session is used to store the game object
      it is static in order to allow access from different scenes
    */
    public static class Session
    {
        public static Game game;
    }
}