using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VRButton : MonoBehaviour
{

    public bool playGame, quit, craft;

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
        if (other.gameObject.tag == "Hand")
        {
            if (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0.5f || OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.5)
            {
                if (playGame)
                    PlayGame();
                else if (quit)
                    Quit();
                else if (craft)
                {
                    Craft();
                }
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

    void Craft()
    {
        print("craft");
        bool craft = GameObject.FindGameObjectWithTag("CraftingRock").GetComponent<Crafting>().craft = true;
        //StartCoroutine(WaitAndResume(craft));
    }

    private IEnumerator WaitAndResume(bool craft)
    {
        yield return new WaitForSeconds(2);
        craft = false;

        print(GameObject.FindGameObjectWithTag("CraftingRock").GetComponent<Crafting>().craft);
    }
}
