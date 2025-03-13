using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collisions : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object we collided with has a tag called 'Not good'
        if (collision.gameObject.tag == "Not good")
        {
            // Perform the appropriate response, such as reducing health
            Debug.Log("Collided with Not Good!");
        }
    }
}

