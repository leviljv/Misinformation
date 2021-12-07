using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    
    public int currentDialog;
    void Start()
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
        //Debug.Log("Playerstats node 1 set to" + PlayerStats.Node1);
    }

    public void SetNode2VarToStatic(int setNode2To) //change the int in the static PlayerStat script for Node 2
    {
        PlayerStats.Node2 = setNode2To;
        //Debug.Log("Playerstats node 2 set to" + PlayerStats.Node2);

    }

    public void SetNode3VarToStatic(int setNode3To) //change the int in the static PlayerStat script for Node 2
    {
        PlayerStats.Node3 = setNode3To;
        //Debug.Log("Playerstats node 3 set to" + PlayerStats.Node3);

    }
}
