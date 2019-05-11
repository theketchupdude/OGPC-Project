using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {

    public GameObject Flint;

    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Rock")
        {
            Destroy(collision.gameObject);
            Instantiate(Flint, gameObject.transform);
            Destroy(gameObject);
        }
    }
}
