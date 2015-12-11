using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
    public Transform target;
    public float M_speed = 0.1f;
    Camera mycam;
	// Use this for initialization
	void Start () {
        mycam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        mycam.orthographicSize = (Screen.height / 100f) / .5f;

        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, M_speed) + new Vector3(0,0, -10);
        }
	}
}
