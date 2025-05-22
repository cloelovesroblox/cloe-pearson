using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_point_detection : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform starting_point; // Set this in Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Check if player touches checkpoint
        {
            Debug.Log("Checkpoint reached! Moving back to start.");
            other.transform.position = starting_point.position; // Move player back
        }
    }
}
