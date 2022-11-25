<<<<<<< HEAD
//Jordan Allen
//12/09/2022
=======
>>>>>>> ab52ca697053c30e587dd223b6d8ec19adcc1cf3
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
<<<<<<< HEAD
    public void PlayGame ()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    public void QuitGame ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
=======
   public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
        Debug.Log("QUITTTING!!!!!!!");
    }
}

>>>>>>> ab52ca697053c30e587dd223b6d8ec19adcc1cf3
