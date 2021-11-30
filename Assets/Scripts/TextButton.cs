using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextButton : MonoBehaviour
{
    public UIManager uiManager;
    private Color textColor;
    private Color standardColor;

    private void Awake()
    {
        standardColor = GetComponent<Image>().color;
    }

    public void clickText()
    {
        if (uiManager.bluePressed == true && textColor != Color.blue)
        {
            textColor = Color.blue;
            textColor.a = 0.36f;
            GetComponent<Image>().color = textColor;
            textColor = Color.blue;
        }
        else if (uiManager.greenPressed == true && textColor != Color.green)
        {
            textColor = Color.green;
            textColor.a = 0.36f;
            GetComponent<Image>().color = textColor;
            textColor = Color.green;
        }
        else if (uiManager.greenPressed == true && textColor == Color.green || uiManager.bluePressed == true && textColor == Color.blue)
        {
            GetComponent<Image>().color = standardColor;
            textColor = standardColor;
        }
        
    }
}
