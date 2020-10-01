using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
   public float speed = 50;
   
    // Update is called once per frame
    void Update()
    {
        // rotate the propeller at a constant rate
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
