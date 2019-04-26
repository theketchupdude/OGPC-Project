using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour {

    Light lite;

	// Use this for initialization
	void Start () {
        lite = gameObject.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        lite.intensity = Random.value;
	}
}
