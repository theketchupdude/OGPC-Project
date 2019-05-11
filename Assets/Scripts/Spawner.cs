using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public List<GameObject> spawnableObjects = new List<GameObject>();

    public Vector2 timerRange;
    float timerCounter;

    public bool onlyAtNight = false;

    bool isColiding;

    GameObject moon;

	// Use this for initialization
	void Start () {
        // Start a timer between the ranges specified in the inspector
        timerCounter = Random.Range(timerRange.x, timerRange.y);

        moon = GameObject.FindGameObjectWithTag("Moon");
	}
	
	// Update is called once per frame
	void Update () {
        // Timer
		if (timerCounter > 0) {
            timerCounter -= Time.deltaTime;
        } else
        {
            timerCounter = Random.Range(timerRange.x, timerRange.y);
            // If nothing is coliding with the spawner, spawn something
            if (!onlyAtNight && !isColiding)
                Spawn();
            else if (onlyAtNight && !isColiding)
            {
                if (moon.GetComponent<Sun>().lit.enabled)
                {
                    Spawn();
                }
            }
        }
	}

    public void Spawn()
    {
        // Instantiate gameobject randomly selected from the list in the inspector
        GameObject spawnedObject = Instantiate(spawnableObjects[Random.Range(0, spawnableObjects.Count)]);
        // Reset the gameobjects position to center it on the spawner
        spawnedObject.transform.position = transform.position;
        string[] name = spawnedObject.name.Split('(');
        spawnedObject.name = name[0];

    }

    // Check if something is coliding with the spawner
    private void OnCollisionEnter(Collision collision)
    {
        isColiding = true;
    }

    // Set it back to clear if nothing is coliding with the spawner
    private void OnCollisionExit(Collision collision)
    {
        isColiding = false;
    }
}
