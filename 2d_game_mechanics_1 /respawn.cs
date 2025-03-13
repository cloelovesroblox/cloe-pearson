using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
    {
    // This variable holds the point in the game world where the player should respawn
    public Transform respawnPoint;

    // this is the player object that will be respawned. Assign the player prefab in Unity Editor.
    public GameObject playerPrefab;

    // This function is responsible for respawning the player 
    public void respawnPlayer() {
        // Check if we have both the player prefab and a respawn point set
        if (playerPrefab && respawnPoint) {
            // Create a new instance of the player at the respawn point with no rotation
                  Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);

      }  
    }
}
