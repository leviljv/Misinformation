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
    }

    public void greenPress()
    {
        greenPressed = true;
        bluePressed = false;
    }

}
