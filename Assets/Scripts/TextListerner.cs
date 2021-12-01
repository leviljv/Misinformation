using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextListerner : MonoBehaviour
{
    public int level;
    public GameObject text;
    public NextPreviousText nextPreviousText;

    void Start()
    {
        
    }

    void Update()
    {
        if(nextPreviousText.level == level)
        {
            text.SetActive(true);
        }
        else
        {
            text.SetActive(false);
        }
    }
}
