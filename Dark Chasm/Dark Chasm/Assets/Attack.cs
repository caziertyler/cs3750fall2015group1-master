using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
//using UnityEditor;

namespace RPGClasses
{
    public class Attack : MonoBehaviour
    {
        string spell = null;
        string battleChoice = null;
        bool isTurn = false;
        bool enemyDied = false;
        int enemyTarget = -1;
        List<Character> heroes = Session.game.party.Characters;
        List<Character> enemies = Session.game.enemies.Characters;
        // Use this for initialization
        Character charactersTurn = null;
        List<GameObject> enemyButtons = new List<GameObject>();
        GameObject eventSystem;
        System.Random random = new System.Random(DateTime.UtcNow.Millisecond);
        void Start()
        {

            StartCoroutine(UpdateState());
        }

        IEnumerator UpdateState()
        {
            eventSystem = GameObject.FindGameObjectWithTag("EventSystem");
            eventSystem.SetActive(false);
            for (int i = 0; i < enemies.Count; i++)
            {
                GameObject[] temp = (GameObject.FindGameObjectsWithTag("EnemyButton" + i));
                foreach (GameObject g in temp)
                {
                    g.GetComponent<Text>().text = enemies[i].Name;
                    enemyButtons.Add(g);
                }
            }
            yield return new WaitForSeconds(0.9f);
            for (;;)
            {
                if(enemyDied == true)
                {
                    enemyDied = false;
                    DestroyObject(enemyButtons[enemyButtons.Count - 1]);
                    enemyButtons.Remove(enemyButtons[enemyButtons.Count - 1]);
                    DestroyObject(enemyButtons[enemyButtons.Count - 1]);
                    enemyButtons.Remove(enemyButtons[enemyButtons.Count - 1]);
                    yield return new WaitForSeconds(.9f);
                }
                if (!isTurn)
                {
                    //This is short hand for infinity loop.  Same as while(true). 
                    if (charactersTurn == null)
                    {

                        foreach (Hero hero in heroes)
                        {
                            hero.Timer += 1;
                            if (hero.Timer <= 100)
                            {
                                StartCoroutine(updateTimer(hero));
                            }
                            if (hero.Timer >= 100)
                            {
                                hero.BattleStats.Timer.value = 100;
                                isTurn = true;
								hero.IsTurn = true;
                                charactersTurn = hero;
                                if (enemies.Count > 0)
                                {
                                    hero.BattleObject.transform.Translate(new Vector3(-2f, 0f, 0f));
                                }
                                break;
                            }
                        }
                    }
                    if (charactersTurn == null)
                    {
                        foreach (Character enemy in enemies)
                        {
                            enemy.Timer += 1;
                            if (enemy.Timer >= 100)
                            {
                                isTurn = true;
                                charactersTurn = enemy;
                                //enemy.BattleObject.transform.Translate(new Vector3(2f, 0f, 0f));
                                break;
                            }
                        }
                    }
                    yield return null;
                    //Start our player loop, and wait for it to finish
                    //Before we continue.
                    //yield return StartCoroutine(EnemyTurn();
                    //Do enemy loop, finish, restart loop
                }
                if (enemies.Count < 1)
                {
                    foreach(Hero hero in heroes)
                    {
                        hero.Timer = 0;
                    }
                    StartCoroutine(WaitForVictoryScreen());
                    isTurn = false;
                }
                if (heroes.Count < 1)
                {
                    StartCoroutine(WaitForGameOverScreen());
                    isTurn = false;
                }
                if (isTurn)
                {
                    yield return StartCoroutine(PlayerTurn(charactersTurn));
                }
            }
        }

        public IEnumerator updateTimer(Hero hero)
        {
            hero.BattleStats.Timer.value += 1f;
            yield return null;
        }

        public IEnumerator updateHeroStats()
        {
            foreach (Character character in heroes)
            {
                character.BattleStats.Health.text = "HP: " + character.CurrentHp + "/" + character.Hp;
                character.BattleStats.RunePower.text = "RP: " + character.CurrentRunePower + "/" + character.RunePower;
            }
            yield return null;
        }

        public IEnumerator WaitForAbility(GameObject gObject, Character charObj = null)
        {
            yield return new WaitForSeconds(0.9f);
            Destroy(gObject);
            if (charObj != null && charObj.CurrentHp <= 0)
            {
                Destroy(charObj.CharacterObject);
            }

        }
        public IEnumerator WaitForVictoryScreen()
        {
            yield return new WaitForSeconds(1.5f);
            ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();
            yield return StartCoroutine(sf.FadeToBlack());
            Application.LoadLevel("FirstScene");
            MonoBehaviour moveScript = (Session.game.mainCharacter.GetComponent("Move") as MonoBehaviour);
            moveScript.enabled = true;
            yield return StartCoroutine(sf.FadeToClear());
        }

        public IEnumerator EscapeSuccess()
        {
            foreach (Hero hero in heroes)
            {
                hero.Timer = 0;
            }
            ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();
            yield return StartCoroutine(sf.FadeToBlack());
            Application.LoadLevel("FirstScene");
            MonoBehaviour moveScript = (Session.game.mainCharacter.GetComponent("Move") as MonoBehaviour);
            moveScript.enabled = true;
            yield return StartCoroutine(sf.FadeToClear());
        }

        public IEnumerator WaitForGameOverScreen()
        {
            //yield return new WaitForSeconds(2.9f);
            ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();
            yield return StartCoroutine(sf.FadeToBlack());
            Application.LoadLevel("FirstScene");
            MonoBehaviour moveScript = (Session.game.mainCharacter.GetComponent("Move") as MonoBehaviour);
            moveScript.enabled = true;
            yield return StartCoroutine(sf.FadeToClear());
        }
        public IEnumerator PlayerTurn(Character hero)
        {
            eventSystem.SetActive(true);
            bool choice = false;
            if (hero is Hero)
            {
                while (!choice)
                {
                    if (battleChoice == "Attack")
                    {
                        eventSystem.SetActive(false);
                        battleChoice = null;
                        choice = true;
                        Character enemy = enemies[enemyTarget];
                        hero.Attack(hero, enemy);
                        //GameObject battleText = GameObject.FindGameObjectWithTag("BattleText");
                        //battleText.GetComponent<Text>().text = "Attack";
                        if (enemy.CurrentHp == 0)
                        {
                            enemyDied = true;
                            StartCoroutine(WaitForAbility(GameObject.FindGameObjectWithTag(enemy.CharacterObject.tag), enemy));
                            enemies.Remove(enemy);
                        }
                    }
                    if (battleChoice == "Rune")
                    {
                        eventSystem.SetActive(false);
                        battleChoice = null;
                        choice = true;
                        Character enemy = enemies[enemyTarget];
                        //var spell = hero.Runes.First();
                        hero.Runes[spell].castRune(hero, enemy);
                        //GameObject battleText = GameObject.FindGameObjectWithTag("BattleText");
                        //battleText.GetComponent<Text>().text = spell.Key.ToString();
                        //GameObject abilityObject = GameObject.FindGameObjectWithTag("Clone");
                        StartCoroutine(WaitForAbility(GameObject.FindGameObjectWithTag(spell), enemy));
                        if (enemy.CurrentHp == 0)
                        {
                            enemyDied = true;
                            Debug.Log(enemy.CurrentHp);
                            enemies.Remove(enemy);
                        }
                    }
                    if (battleChoice == "Escape")
                    {
                        enemies.Clear();
                        StartCoroutine(EscapeSuccess());
                    }
                    yield return null;
                }

                isTurn = false;
                charactersTurn = null;
                hero.Timer = 0;
                enemyTarget = -1;
                hero.BattleStats.Timer.value = 1f;
                hero.BattleObject.transform.Translate(new Vector3(2f, 0f, 0f));
            }
            else
            {
                eventSystem.SetActive(false);
                Character enemy = heroes[Convert.ToInt32(Math.Floor((double)(random.Next(1, 99) / 25)))];
                hero.Attack(hero, enemy);
                if (enemy.CurrentHp == 0)
                {
                    StartCoroutine(WaitForAbility(GameObject.FindGameObjectWithTag(hero.CharacterObject.tag)));
                }
                yield return new WaitForSeconds(0.5f);
                isTurn = false;
                charactersTurn = null;
                hero.Timer = 1;
                enemyTarget = -1;
                //hero.BattleObject.transform.Translate(new Vector3(-2f, 0f, 0f));
            }
            StartCoroutine(updateHeroStats());
            yield return new WaitForSeconds(2f);
        }
        public void castRune(int enemy)
        {
            if (charactersTurn is Hero)
            {
                battleChoice = "Rune";
                enemyTarget = enemy;
            }
        }
        public void normalAttack(int enemy)
        {
            if (charactersTurn is Hero)
            {
                battleChoice = "Attack";
                enemyTarget = enemy;
            }
        }
        public void selectRune(string rune)
        {
            if (charactersTurn is Hero)
            {
                spell = rune;
            }
        }
        public void Escape()
        {
            if (charactersTurn is Hero)
            {
                battleChoice = "Escape";
            }
        }
    }
}