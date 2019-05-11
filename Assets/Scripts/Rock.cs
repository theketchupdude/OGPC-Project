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
            GameObject temp = Instantiate(Flint, transform.position, Quaternion.identity);
            temp.transform.parent = null;
            string[] name = temp.name.Split('(');
            temp.name = name[0];
            Destroy(collision.gameObject);
        }
    }
}
