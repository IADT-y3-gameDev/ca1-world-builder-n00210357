using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{

    Vector3 pivotPoint = new Vector3 (0,0,0);
  
    public float degreesPerSecond = 20;

    // Update is called once per frame
    void Update()
    {
        // Rotates around the pivot point and the Y-Axis by 90 degrees
  
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
    }

}   

