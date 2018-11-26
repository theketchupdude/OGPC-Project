using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void CloseApplication ()
    {
        Debug.Log("Closing Application.."); // This is simply for testing purposes
        Application.Quit(); // This only closes the application if ran by the direct .exe file
    }
	
}
