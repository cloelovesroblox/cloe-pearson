using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject objectToSpawn; 

    public Transform spawnpoint; 

    void Start()
    {
        spawnObject();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnObject()
    {
        Instantiate(objectToSpawn, spawnpoint.position, spawnpoint.rotation);
    }
    
    
}
