using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public int currentScene;
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex; //gets the current scene
    }

    public void GoToNextScene()  //goes to the next scene after the current scene
    {
        SceneManager.LoadScene(currentScene += 1);
    }

    public void GoToLastScene() //goes to the previous scene before the current scene
    {
        
        SceneManager.LoadScene(currentScene -= 1);
    }

    public void GoToSpecificScene(int targetSceneToLoad) //goes to a specific scene, needs to be specified when calling this function from anywhere
    {     
        SceneManager.LoadScene(targetSceneToLoad);
    }
}
