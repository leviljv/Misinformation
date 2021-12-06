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

    public void SetNode1VarToStatic(int setNode1To) //change the int in the static PlayerStat script for Node 1
    {
        PlayerStats.Node1 = setNode1To;
    }

    public void SetNode2VarToStatic(int setNode2To) //change the int in the static PlayerStat script for Node 2
    {
        PlayerStats.Node2 = setNode2To;
    }
}
