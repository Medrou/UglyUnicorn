﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSpawn : MonoBehaviour
{
    public GameObject DiamondRed, DiamondBlue;

    public float spawnRate = 3f;

    public float nextSpawn = 8f;

    int whatToSpawn;

   

    // Update is called once per frame



    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 3);
            
            
            

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(DiamondRed, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(DiamondBlue, transform.position, Quaternion.identity);
                    break;
            }
            nextSpawn = Time.time + spawnRate;
        }
        
    }
}
