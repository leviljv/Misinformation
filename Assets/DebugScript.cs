using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour
{
    public bool debugWhichBools;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (debugWhichBools)
        {
            Debug.Log(PlayerStats.Node1 + "&" + PlayerStats.Node2);
        }
    }
}
