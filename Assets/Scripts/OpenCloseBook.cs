using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCloseBook : MonoBehaviour
{
    public GameObject openBook;

    public void clickOpen()
    {
        openBook.GetComponent<Canvas>().enabled = true;
    }
    public void clickClose()
    {
        openBook.GetComponent<Canvas>().enabled = false;
    }
}
