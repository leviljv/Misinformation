using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNode : MonoBehaviour
{
    public DialogManager refToDialogManager;
    public GameObject refToGameObject;
    public int targetIntWhenOnMin, targetIntWhenOnMax, addToMaxInt; //whenonmax =  after what treshold the text is off, addToMaxInt can be filled in to not have to manually fill in each int, but just adds a number assigned in the inspector to the max int (so for a 2opt choice it woulld be +2)
    void Start()
    {
        targetIntWhenOnMax = targetIntWhenOnMin + addToMaxInt; //leave addtomaxint blanc if you want to fill everything outyoutself
    }

    
    void Update()
    {
        CheckForOn();
    }

    void CheckForOn()
    {
        if(refToDialogManager.currentDialog >= targetIntWhenOnMin && refToDialogManager.currentDialog <= targetIntWhenOnMax)
        {
            EnableThisDialog();
        } else
        {
            DisableThisDialog();
        }
    }

    void EnableThisDialog()
    {
        refToGameObject.SetActive(true);
        Debug.Log("on");
    }

    void DisableThisDialog()
    {
        refToGameObject.SetActive(false);
        Debug.Log("off");

    }
}
