using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Button blueButton;
    [SerializeField]
    private Button greenButton;

    public bool bluePressed = false;
    public bool greenPressed = false;
    public bool yellowPressed = false;
    public bool redPressed = false;
    public bool magentaPressed = false;
    public bool whitePressed = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void bluePress()
    {
        greenPressed = false;
        bluePressed = true;
        yellowPressed = false;
        redPressed = false;
        magentaPressed = false;
        whitePressed = false;
    }

    public void greenPress()
    {
        greenPressed = true;
        bluePressed = false;
        yellowPressed = false;
        redPressed = false;
        magentaPressed = false;
        whitePressed = false;
    }

    public void yellowPress()
    {
        greenPressed = false;
        bluePressed = false;
        yellowPressed = true;
        redPressed = false;
        magentaPressed = false;
        whitePressed = false;
    }

    public void redPress()
    {
        greenPressed = false;
        bluePressed = false;
        yellowPressed = false;
        redPressed = true;
        magentaPressed = false;
        whitePressed = false;
    }

    public void magentaPress()
    {
        greenPressed = false;
        bluePressed = false;
        yellowPressed = false;
        redPressed = false;
        magentaPressed = true;
        whitePressed = false;
    }

    public void whitePress()
    {
        greenPressed = false;
        bluePressed = false;
        yellowPressed = false;
        redPressed = false;
        magentaPressed = false;
        whitePressed = true;
    }
}
