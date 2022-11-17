using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //Loads scene 1
    public void startbutton()
    {
        SceneManager.LoadScene("Game1");
        
    }

    // Exits game app
    public void exitgamebutton()
    {
        Application.Quit();
    }

}
