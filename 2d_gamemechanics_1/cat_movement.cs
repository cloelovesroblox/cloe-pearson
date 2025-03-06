using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat_movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed = 4.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
        float horizontalInput = Input.GetAxis("Horizontal");
        
        Vector3 direction = new Vector3(horizontalInput, 0, 0);
        
        transform.Translate(direction * _speed * Time.deltaTime);
      }
        
   }

