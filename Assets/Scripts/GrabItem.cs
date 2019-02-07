using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.Touch) > 0 || OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger, OVRInput.Controller.Touch) > 0)
        {
            print("Grab Button Pressed");
        }

        if (OVRInput.Get(OVRInput.Button.Two))
        {
            print("Pleaseeee");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        print("Hand Collided");

        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) > 0 || OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) > 0)
        {
            print("Grabbed Object");

            other.gameObject.transform.SetParent(this.gameObject.transform);
            other.gameObject.transform.position = Vector3.zero;
        }
    }
}
