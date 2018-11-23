using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour {

    GameObject player;

    public float speed;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("VR Rig");
	}
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;

		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);

        transform.rotation = new Quaternion(0, transform.rotation.y, 0, transform.rotation.w);
	}
}
