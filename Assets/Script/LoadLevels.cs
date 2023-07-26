using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour
{
    public void LoadLevel()
    {
        // load the nextlevel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
    public void LoadMyMenu() 
    {
        SceneManager.LoadScene("MyMenu");

    }
}
