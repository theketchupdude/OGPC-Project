using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VRButton : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name);
        if (other.gameObject.tag == "Hand")
        {
            if (OVRInput.Axis1D.PrimaryIndexTrigger > 0 || OVRInput.Axis1D.SecondaryIndexTrigger > 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
