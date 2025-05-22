using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyInputsJump : MonoBehaviour
{
    public Rigidbody rb;
    public float Jumpforce;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component
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
        rb.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse); // Apply force upwards
    }
}
