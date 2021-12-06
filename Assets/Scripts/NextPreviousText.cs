using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPreviousText : MonoBehaviour
{
    public int level;

    private void Start()
    {
        if (PlayerStats.Node1 == 2 || PlayerStats.Node1 == 3 )
        {
            if (PlayerStats.Node2 == 2)
            {
                level = 1;
            }
        }
        else
        {
            level = 2;
        }
    }

    void Update()
    {
        
    }

    public void nextText()
    {
        level++;
    }
    public void previousText()
    {
        level--;
    }
}
