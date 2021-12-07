using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class CutsceneController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    [SerializeField] Image image;
    [SerializeField] GameObject Detectivehappy;
    [SerializeField] GameObject Detectiveregular;
    [SerializeField] GameObject Detectiveworried;

    [SerializeField] Sprite detectiveWorried;
    [SerializeField] Sprite detectiveHappy;
    [SerializeField] Sprite detectiveRegular;

    [SerializeField] GameObject Grandmahappy;
    [SerializeField] GameObject Grandmaregular;
    [SerializeField] GameObject Grandmaworried;

    [SerializeField] GameObject textBox;
    [SerializeField] GameObject[] nextButton;

    int convoIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject button in nextButton)
        {
            button.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(convoIndex == 1)
        {
            image.sprite = detectiveRegular;
            
            text.text = "GRANDMA: There's a strange man at my door who is trying to sell me something.";
        }

        if (convoIndex == 2)
        {
            image.sprite = detectiveWorried;
            text.text = "YOU: What? Who is he, what is he selling? Is it legit?";
        }

        if (convoIndex == 3)
        {
            text.text = "GRANDMA: I don't know, sweetheart. Could you help me find out?";
        }

        if (convoIndex == 4)
        {
            image.sprite = detectiveHappy;
            text.text = "YOU: I'm on my way!";
            
        }

        if(convoIndex >= 4)
        {
            StartCoroutine(GoToNextScene());
            convoIndex = 4;
            
        }
    }

    public void ContinueConvo()
    {
        text.text = "GRANDMA: Hello, sweetheart.";
        foreach(GameObject button in nextButton)
        {
            button.SetActive(true);
        }
    }

    IEnumerator GoToNextScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("KimScene", LoadSceneMode.Additive);
    }
    public void Next()
    {
        convoIndex++;
    }
}
