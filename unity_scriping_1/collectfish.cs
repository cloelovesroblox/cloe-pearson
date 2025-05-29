using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectfish : MonoBehaviour

{
    public int points = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Find the ScoreDisplay script and add score
            ScoreDisplay scoreDisplay = FindObjectOfType<ScoreDisplay>();
            if (scoreDisplay != null)
            {
                scoreDisplay.AddScore(points);
            }

            // Destroy the fish after collecting it
            Destroy(gameObject);
        }
    }
}
