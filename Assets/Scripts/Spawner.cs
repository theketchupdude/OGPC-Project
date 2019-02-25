using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public List<GameObject> spawnableObjects = new List<GameObject>();

    public Vector2 timerRange;
    public float timerCounter;

	// Use this for initialization
	void Start () {
        timerCounter = Random.Range(timerRange.x, timerRange.y);
	}
	
	// Update is called once per frame
	void Update () {
		if (timerCounter > 0) {
            timerCounter -= Time.deltaTime;
        } else
        {
            timerCounter = Random.Range(timerRange.x, timerRange.y);
            Spawn();
        }
	}

    public void Spawn()
    {
        GameObject spawnedObject = Instantiate(spawnableObjects[Random.Range(0, spawnableObjects.Count)]);
        spawnedObject.transform.position = transform.position;

    }
}
