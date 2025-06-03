using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParallaxBackground : MonoBehaviour
{
    public Transform player; // Drag your player here in the Inspector
    public float parallaxEffect = 0.5f; // Lower = slower background movement

    private Vector3 lastPlayerPosition;

    void Start()
    {
        if (player != null)
            lastPlayerPosition = player.position;
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 deltaMovement = player.position - lastPlayerPosition;
            transform.position += new Vector3(deltaMovement.x * parallaxEffect, 0f, 0f);
            lastPlayerPosition = player.position;
        }
    }
}

