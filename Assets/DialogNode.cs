using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNode : MonoBehaviour
{
    public DialogManager refToDialogManager;
    public GameObject refToGameObject;
    public int targetIntWhenOnMin, targetIntWhenOnMax;
    void Start()
    {
        
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
    }

    void DisableThisDialog()
    {
        refToGameObject.SetActive(false);

    }
}
