using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sf : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Vertical") < -0.1) {
            transform.position += Vector3.back * 1;
        } else if (Input.GetAxis("Vertical") > 0.1) {
            transform.position += Vector3.forward * 1;
        }
	}
}
