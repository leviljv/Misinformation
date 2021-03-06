using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextButton : MonoBehaviour
{
    public UIManager uiManager;
    private Color textColor;
    private Color standardColor;
    public bool rightColorBlue;
    public bool rightColorGreen;
    private bool pointGiven = false;

    private void Awake()
    {
        standardColor = GetComponent<Image>().color;
    }

    private void Update()
    {
        
            Debug.Log(PlayerStats.Points + "goede herkenningen");
    }

    public void clickText()
    {
        if (uiManager.bluePressed == true && textColor != Color.blue)
        {
            textColor = Color.blue;
            textColor.a = 0.36f;
            GetComponent<Image>().color = textColor;
            textColor = Color.blue;
            if (rightColorBlue && !pointGiven)
            {
                PlayerStats.Points++;
                pointGiven = true;
            }
        }
        else if (uiManager.greenPressed == true && textColor != Color.green)
        {
            textColor = Color.green;
            textColor.a = 0.36f;
            GetComponent<Image>().color = textColor;
            textColor = Color.green;

            if (rightColorGreen && !pointGiven)
            {
                PlayerStats.Points++;
                pointGiven = true;
            }
        }
        else if (uiManager.yellowPressed == true && textColor != Color.yellow)
        {
            textColor = Color.yellow;
            textColor.a = 0.36f;
            GetComponent<Image>().color = textColor;
            textColor = Color.yellow;
        }
        else if (uiManager.redPressed == true && textColor != Color.red)
        {
            textColor = Color.red;
            textColor.a = 0.36f;
            GetComponent<Image>().color = textColor;
            textColor = Color.red;
        }
        else if (uiManager.magentaPressed == true && textColor != Color.magenta)
        {
            textColor = Color.magenta;
            textColor.a = 0.36f;
            GetComponent<Image>().color = textColor;
            textColor = Color.magenta;
        }
        else if (uiManager.whitePressed == true || uiManager.greenPressed == true && textColor == Color.green || uiManager.bluePressed == true && textColor == Color.blue
             || uiManager.yellowPressed == true && textColor == Color.yellow || uiManager.redPressed == true && textColor == Color.red || uiManager.magentaPressed == true && textColor == Color.magenta)
        {
            GetComponent<Image>().color = standardColor;
            textColor = standardColor;
        }
        
    }
}
