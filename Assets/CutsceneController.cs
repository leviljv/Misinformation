using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CutsceneController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameObject Detectivehappy;
    [SerializeField] GameObject Detectiveregular;
    [SerializeField] GameObject Detectiveworried;

    [SerializeField] GameObject Grandmahappy;
    [SerializeField] GameObject Grandmaregular;
    [SerializeField] GameObject Grandmaworried;

    [SerializeField] GameObject textBox;
    [SerializeField] GameObject nextButton;

    int convoIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        nextButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(convoIndex == 1)
        {
            text.text = "GRANDMA: There's a strange man at my door who is trying to sell me something.";
        }

        if (convoIndex == 2)
        {
            text.text = "YOU: What? Who is he, what is he selling? Is it legit?";
        }

        if (convoIndex == 3)
        {
            text.text = "GRANDMA: I don't know, sweetheart. Could you help me find out?";
        }

        if (convoIndex == 4)
        {
            text.text = "YOU: I'm on my way!";
            //gotoscene
        }

        if(convoIndex >= 4)
        {
            convoIndex = 4;
            
        }
    }

    public void ContinueConvo()
    {
        text.text = "GRANDMA: Hello, sweetheart.";
        nextButton.SetActive(true);
    }

    public void Next()
    {
        convoIndex++;
    }
}
