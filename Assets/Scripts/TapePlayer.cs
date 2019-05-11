using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapePlayer : MonoBehaviour {

    AudioSource audioS;

    public List<AudioClip> audiosrc = new List<AudioClip>();

	// Use this for initialization
	void Start () {
        audioS = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tape") {
            switch (collision.gameObject.name) {
                case "Tape 1":
                    audioS.clip = audiosrc[0];
                    audioS.Play();
                    break;
                case "Tape 2":
                    audioS.clip = audiosrc[1];
                    audioS.Play();
                    break;
            }
        }
    }
}
