using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPreviousText : MonoBehaviour
{
    public int level;
    public NextScene sceneManager;

    private void Start()
    {
        //to test the reading of PlayerStats
        //PlayerStats.Node1 = 1;
        //PlayerStats.Node2 = 2;
        //PlayerStats.Node3 = 1;
    }

    void Update()
    {
        
    }

    public void nextText()
    {
        if (level == 1)
        {
            if (PlayerStats.Node1 == 1)
            {
                level = 2;
            }
            else if (PlayerStats.Node1 == 2)
            {
                level = 3;
            }
        }
        else if (level == 2 || level == 3)
        {
            if (PlayerStats.Node2 == 1)
            {
                level = 4;
            }
            else if (PlayerStats.Node2 == 2)
            {
                level = 5;
            }
        }
        else if (level == 4 || level == 5)
        {
            if (PlayerStats.Node3 == 1)
            {
                level = 6;
            }
            else if (PlayerStats.Node3 == 2)
            {
                level = 7;
            }
        }
        else if (level == 6 || level == 7)
        {
            level = 8;
        }
        else if (level >= 10)
        {
            sceneManager.GoToNextScene();
        }
        else
        {
            level++;
        }
    }
    public void previousText()
    {
        level--;
    }
}
