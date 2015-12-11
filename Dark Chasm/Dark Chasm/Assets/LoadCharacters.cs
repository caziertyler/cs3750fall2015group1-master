using UnityEngine;
using UnityEngine.UI;
//using UnityEditor;
//using System.Collections;

namespace RPGClasses
{
    public class LoadCharacters : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            Game game = Session.game;
            int count1 = 1;
            int count2 = 1;
            for (int i = 0; i < 4; i++)
            {
                game.enemies.Characters.Add(new Skeleton());
            }

            foreach(Hero character in game.party.Characters)
            {
                character.CharacterObject = (GameObject)Resources.Load("Player/Hero"+ count1, typeof(GameObject));
                GameObject heroLocation = GameObject.FindGameObjectWithTag("Hero"+ count1);
                GameObject hero = GameObject.Instantiate(character.CharacterObject, Vector3.zero, Quaternion.identity) as GameObject;
                hero.tag = "Hero" + count1;
                hero.transform.position = heroLocation.transform.position;
                character.CharacterObject.transform.position = heroLocation.transform.position;
                character.BattleStats = GameObject.FindGameObjectWithTag("CharacterStats"+(count1 - 1)).GetComponent<BattleStats>();
                character.BattleStats.Name.text = character.Name;
                character.BattleStats.Health.text = "HP: " + character.CurrentHp + "/" + character.Hp;
                character.BattleStats.RunePower.text = "RP: " + character.CurrentRunePower + "/" + character.RunePower;
                character.BattleObject = hero;
                count1++;
            }

            foreach (Character character in game.enemies.Characters)
            {
                GameObject enemyLocation = GameObject.FindGameObjectWithTag("Enemy" + count2);
                GameObject enemy = GameObject.Instantiate(character.CharacterObject, Vector3.zero, Quaternion.identity) as GameObject;
                enemy.tag = "Enemy" + count2;
                enemy.transform.position = enemyLocation.transform.position;
                character.CharacterObject = enemy;
                count2++;
            }
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}
