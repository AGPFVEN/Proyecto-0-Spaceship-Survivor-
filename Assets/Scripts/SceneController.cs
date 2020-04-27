using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void buttonChangeScene()
    {
        SceneManager.LoadScene("Juego");
    }
    public void buttonExitGame()
    {
        Application.Quit();
    }
}
