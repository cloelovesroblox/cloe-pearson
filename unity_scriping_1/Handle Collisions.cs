using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    

    public int score = 0; // Keeps track of points

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible")) // Check if item has "Collectible" tag
        {
            score += 1; // Add 1 point
            Destroy(other.gameObject); // Remove the item
        }
    }


}
