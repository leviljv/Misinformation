using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    
    public int currentDialog;
    void Start()
    {
        
    }

  

    void Update()
    {
        
    }

    
    public void AddCurrentDialog(int dialogToAdd)
    {
        currentDialog += dialogToAdd;
    }

    public void SetCurrentDialog(int setDialogTo)
    {
        currentDialog = setDialogTo;

    }
}
