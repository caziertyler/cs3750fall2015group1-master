using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

namespace RPGClasses 
    {
    public class StartGame : MonoBehaviour
    {
        public void BeginGame()
        {
            StartCoroutine(loadFirstLevel());
        }
    public IEnumerator loadFirstLevel()
    {
        ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();
        yield return StartCoroutine(sf.FadeToBlack());
        Session.game = new Game();
        DontDestroyOnLoad(Session.game.mainCharacter);
        MonoBehaviour moveScript = ((Session.game.mainCharacter.GetComponent("Move") as MonoBehaviour));
        moveScript.enabled = false;
        Application.LoadLevel("FirstScene");
        moveScript.enabled = true;
        yield return StartCoroutine(sf.FadeToClear());

    }
        public void EndGame()
        {
            Application.Quit();
        }
    }
}
