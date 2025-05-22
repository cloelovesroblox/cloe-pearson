using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectRedFish : MonoBehaviour
{
    public int scoreValue = 5; // Amount to add to score

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Ensure the object colliding is the player
        {
            ScoreManager.instance.AddScore(scoreValue); // Add score
            Destroy(gameObject); // Remove the object from the scene
        }
    }
}

