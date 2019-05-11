using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VRButton : MonoBehaviour
{

    public bool playGame, quit, craft, credit, creditBack;

    public GameObject optionsMenu, mainMenu;

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
                } else if (credit)
                {
                    Credit();
                } else if (creditBack)
                {
                    CreditBack();
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

    void Credit()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    void CreditBack()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    private IEnumerator WaitAndResume(bool craft)
    {
        yield return new WaitForSeconds(2);
        craft = false;

        print(GameObject.FindGameObjectWithTag("CraftingRock").GetComponent<Crafting>().craft);
    }
}
