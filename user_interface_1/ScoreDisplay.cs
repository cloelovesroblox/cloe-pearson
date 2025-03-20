using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Make sure this is for the old Text component if you're not using TextMeshPro

public class ScoreDisplay : MonoBehaviour
{
    // The UI text component that displays the score
    public Text scoreText;

    // Variable to keep track of the current score
    private int currentScore = 0;

    // Method to increase score by a certain amount
    public void AddScore(int pointsToAdd)
    {
        // Add points to the current score
        currentScore += pointsToAdd;

        // Update the display with the new score
        UpdateScoreDisplay();
    }

    // Method to update the score display
    private void UpdateScoreDisplay()
    {
        // Check if scoreText is assigned to prevent errors
        if (scoreText != null)
        {
            // Update the text component with the new score
            scoreText.text = "Score: " + currentScore.ToString();
        }
        else
        {
            Debug.LogError("ScoreText is not assigned in the Inspector!");
        }
    }

    // Example method to simulate score increase over time (for testing)
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))  // Press Space to add 10 points
        {
            AddScore(10);
        }
    }
}






