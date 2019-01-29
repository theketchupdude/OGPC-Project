using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (OVRInput.Axis1D.PrimaryHandTrigger > 0 || OVRInput.Axis1D.SecondaryHandTrigger > 0)
        {
            other.gameObject.transform.SetParent(this.gameObject.transform);
            other.gameObject.transform.position = Vector3.zero;
        }
    }
}
