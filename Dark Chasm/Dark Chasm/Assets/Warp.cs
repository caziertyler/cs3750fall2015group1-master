using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

    public Transform warpTarget;

    IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("An Object Collided. Testing 1..2..3..");
        GameObject character = GameObject.FindGameObjectWithTag("MainCharacter");
        MonoBehaviour moveScript = (character.GetComponent("Move") as MonoBehaviour);
        moveScript.GetComponent<Animator>().SetBool("isWalking", false);
        moveScript.enabled = false;
        ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();
        yield return StartCoroutine(sf.FadeToBlack());
        other.gameObject.transform.position = warpTarget.position;
        Camera.main.transform.position = warpTarget.position + new Vector3(0, 0, -10);
        moveScript.enabled = true;
        yield return StartCoroutine(sf.FadeToClear());

    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
