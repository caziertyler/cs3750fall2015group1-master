using UnityEngine;
using System.Collections;
using RPGClasses;

public class InitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Session.game = new Game ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
