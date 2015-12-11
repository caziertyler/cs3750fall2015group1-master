using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using UnityEngine.UI;
//using UnityEditor;

public class DestroyThisObject : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Destroy(gameObject, .9f);
    }
}
