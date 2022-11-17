using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Home))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Backtomenu();
        }
    }



    public void Backtomenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Retry1()
    {
        SceneManager.LoadScene("Game1");
    }  
    
    public void Retry2()
    {
        SceneManager.LoadScene("Game2");
    }   
    
    public void Retry3()
    {
        SceneManager.LoadScene("Game3");
    }



}
