using UnityEngine;
using System.Collections;

public class LoadBattleScene : MonoBehaviour {

    IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("An Object Collided. Testing 1..2..3..");

        ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();

        yield return StartCoroutine(sf.FadeToBlack());
        Application.LoadLevel("BattleScene");
        yield return StartCoroutine(sf.FadeToClear());

    }
    IEnumerator startBattle()
    {
        Debug.Log("An Object Collided. Testing 1..2..3..");

        ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();

        yield return StartCoroutine(sf.FadeToBlack());
        Application.LoadLevel("BattleScene");
        yield return StartCoroutine(sf.FadeToClear());

    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
