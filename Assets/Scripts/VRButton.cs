using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VRButton : MonoBehaviour
{

    public bool playGame, quit;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name);
        if (other.gameObject.tag == "Hand")
        {
            if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0.5f || OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.5)
            {
                if (playGame)
                    PlayGame();
                else if (quit)
                    Quit();
            }
        }
    }

    void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;

    }
}
