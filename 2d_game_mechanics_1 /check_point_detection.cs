using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_point_detection : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided object has the "Checkpoint" tag
        if (other.CompareTag("Player"))
        {
            Debug.Log("dectection");
            // Destroy the checkpoint
            Destroy(other.gameObject);
        }
    }
}
