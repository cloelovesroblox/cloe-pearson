using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Triggers : MonoBehaviour
{
    // This function is called when this GameObject enters a trigger collider
    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Trigger Activated by: " + other.name); // Debugging to check if trigger works

        // Check if the triggering object has a tag called 'Collectible'
        if (other.CompareTag("Collectible")) 
        {
            // If it's a collectible item, collect it
            CollectItem(other.gameObject);
        }
    }

    // This function handles the collection of items
    void CollectItem(GameObject item) 
    {
        // Here you would put the logic to add the items to the player's inventory
        // For now, we just destroy the item to simulate collection
        Destroy(item);
    }
}

