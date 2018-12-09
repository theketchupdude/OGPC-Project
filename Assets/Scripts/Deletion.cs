using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletion : MonoBehaviour 
{
	
	void OnCollisionEnter(Collision collision) 
    {
		Destroy(collision.gameObject);
	}
}
