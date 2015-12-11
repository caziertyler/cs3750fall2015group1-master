using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

	// Use this for initialization

	void Awake() {
		AudioSource audio = GetComponent<AudioSource> ();

		audio.Play ();
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
