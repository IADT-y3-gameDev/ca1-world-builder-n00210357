using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    //assigns the inventory
    public Transform inven;

    //detects of collided with
    void OnTriggerEnter(Collider other)
    {
        //updates the inventory
        inven.GetComponent<inventory>().carrying += 1;
        
        //removes collectible
        Destroy(gameObject);
        //Debug.Log("picked up");
    }
}
