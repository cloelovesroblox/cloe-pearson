using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    // Start is called before the first frame update
   
    private Rigidbody2D rb;
    public float Jumpforce;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody component
    }

    void Update()
    {
        // Check if the player presses the spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * Jumpforce, ForceMode2D.Impulse); // Apply force upwards
    }
}
