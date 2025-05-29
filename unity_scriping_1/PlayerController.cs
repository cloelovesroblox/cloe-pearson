using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public ScoreDisplay scoreDisplay; // Drag ScoreDisplay GameObject in Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Fish"))
        {
            scoreDisplay.AddScore(5); // Increase score by 1
            Destroy(collision.gameObject); // Remove the fish from the scene
        }
    }
}


