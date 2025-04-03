using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // Add this line

public class start : MonoBehaviour
{
    // This method is triggered when the 'start game' button is clicked
    public void OnStartButtonClick()
    {
        // Load the main game scene; replace "MainGame" with your actual scene name
        SceneManager.LoadScene("MainGame");  // Fix: Use SceneManager with correct capitalization
    }
}

