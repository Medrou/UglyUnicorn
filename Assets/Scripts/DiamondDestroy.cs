using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondDestroy : MonoBehaviour
{
    
     bool colliding = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            colliding = true;
            
        }
    }

   public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
           colliding = false;

        }
    }

    public void ButtonPress()
        {
        Destroy(gameObject);
        if (colliding == true)
        {
            Destroy(gameObject);
        }
        
    }
}
