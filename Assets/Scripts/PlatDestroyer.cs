﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatDestroyer : MonoBehaviour
{
    public GameObject platformDestructionPoint;
    
    
    // Start is called before the first frame update
    void Start()
    {
        platformDestructionPoint = GameObject.Find ("PlatDestructPoint");
       

    }

    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.x < platformDestructionPoint.transform.position.x)
        {

            Destroy(gameObject);

        }

        
    }
}
