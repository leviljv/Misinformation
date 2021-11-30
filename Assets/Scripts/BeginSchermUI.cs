using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginSchermUI : MonoBehaviour
{
    public void playButton()
    {
        SceneManager.LoadScene("Text selection");
    }

    public void closeButton()
    {
        Application.Quit();
    }
}
