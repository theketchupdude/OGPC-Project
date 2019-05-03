using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Rock")
        {
            Destroy(collision.gameObject);
        }
    }
}
