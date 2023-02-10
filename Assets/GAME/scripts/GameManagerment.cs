using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerment : MonoBehaviour
{
    public void GoToScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }
    public void QuitApp()
    {
        Application.Quit();
    }
}