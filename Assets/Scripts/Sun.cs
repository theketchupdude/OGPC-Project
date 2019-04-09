using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {

    [SerializeField]
    float speed = 0.8f;

    Light lit;

    // Use this for initialization
    void Start () {
        lit = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.right, speed * Time.deltaTime);
        transform.LookAt(Vector3.zero);

        if (transform.rotation.x >= 0 && transform.rotation.x <= 180)
        {
            lit.enabled = true;
        }
        else
        {
            lit.enabled = false;
        }
	}
}
