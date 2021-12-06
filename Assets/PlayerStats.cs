using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerStats
{
    public static int dialogueChoice { get; set; }
    public static int Node1 { get; set; } //This is the int for the first choice moment (node1) > 1 = option 1, 2 = option 2, 3 = option 3.  

    public static int Node2 { get; set; } //This is the int for the second choice moment (node1) > 1 = option 1, 2 = option 2, 3 = option 3.  

    public static int Node3 { get; set; } //This is the int for the third choice moment (node1) > 1 = option 1, 2 = option 2, 3 = option 3.  


    //public static bool N1OptA, N1OptB, N1OptC, N2OptA, N2OptB, N2OptC; //dit zijn bools om te checken welk stukje

}
