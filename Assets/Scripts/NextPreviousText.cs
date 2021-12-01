using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPreviousText : MonoBehaviour
{
    public int level;

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
