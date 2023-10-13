using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class inventory : MonoBehaviour
{
    //The amount of collectibles the player has picked up
    public int carrying = 0;

    //The text on the ui
    public TMP_Text text;

    // Update is called once per frame
    public void Update()
    {
        text.text = carrying.ToString();
    }

    
}
