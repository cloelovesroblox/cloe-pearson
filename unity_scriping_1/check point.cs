using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Checkpoint : MonoBehaviour
{
    // Static variable to store the current respawn point for the player
    public static Vector3 CurrentRespawnPoint;

    // This function is triggered when another collider enters the checkpoint's trigger collider
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            // Update the current respawn point to this checkpoint's position
            CurrentRespawnPoint = transform.position;
        }
    }
}

