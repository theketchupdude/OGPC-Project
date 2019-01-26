using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string[] joystickNames = Input.GetJoystickNames(); ;

        for (int i = 0; i < joystickNames.Length; i++)
        {
            print(joystickNames[i]);
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
