using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScenes : MonoBehaviour
{
    public NextScene sceneManager;

    public void Click()
    {
        if (PlayerStats.Points > 2)
        {
            sceneManager.GoToNextScene();
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
