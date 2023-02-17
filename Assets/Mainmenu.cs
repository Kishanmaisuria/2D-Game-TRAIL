using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{

    public void PlayGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exit() 
    {
        Debug.Log("Quit");
        Application.Quit();


    }
    public void Retry()     
    {
        SceneManager.LoadScene(1);
    }

    public void Replay() 
    {
        SceneManager.LoadScene(0);

    }

}
