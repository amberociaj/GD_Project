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
    }

    public void Backtomenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Retry1()
    {
        SceneManager.LoadScene("Game");
    }  
    
    public void Retry2()
    {
        SceneManager.LoadScene("Game2");
    }   
    
    public void Retry3()
    {
        SceneManager.LoadScene("Game3");
    }

    public void NextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
