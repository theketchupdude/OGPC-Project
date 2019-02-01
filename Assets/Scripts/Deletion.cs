using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deletion : MonoBehaviour {
	
	void OnCollisionEnter(Collision collision) 
    {
        if (!(collision.gameObject.tag == "Player")) {
            Destroy(collision.gameObject);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
	}
}
