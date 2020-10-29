using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Destroy this object
        Destroy(gameObject);
        
        // Destroy other object this object is colliding with
        Destroy(other.gameObject);
    }
}
