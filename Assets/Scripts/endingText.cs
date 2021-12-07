using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endingText : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "You learned how to recognize emotional trigger! \nYou managed to recognize " + PlayerStats.Points + " of them! \nLet's see how this story ends for our favorite detective.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
