using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour {

    Light lite;

    public Vector2 lifeTimeRange = new Vector2(130, 210);
    float lifeTime;

	// Use this for initialization
	void Start () {
        lite = gameObject.GetComponent<Light>();

        lifeTime = Random.Range(lifeTimeRange.x, lifeTimeRange.y);
	}
	
	// Update is called once per frame
	void Update () {
        lite.intensity = Random.value;

        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0)
        {
            lite.intensity = 0;
        } else if (lifeTime <= 10)
        {
            lite.intensity = Random.Range(0, lifeTime);
        }
	}
}
