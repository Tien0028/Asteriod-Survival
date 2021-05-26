using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void Quit()
    {
        Debug.Log("Quit Button pushed");
        Application.Quit();
    }
    
}
