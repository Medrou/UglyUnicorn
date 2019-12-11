using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlue : MonoBehaviour
{

    
    public bool colliding;
    GameObject colliderobject;
    public int score;
    
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PressButton()
    {
        if (colliderobject != null)
        {
            
            Destroy(colliderobject);
            Score.scoreValue += 1;
        }

        



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "diamondBlue")
        {
            colliding = true;
            colliderobject = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "diamondBlue")
        {
            colliding = false;
            colliderobject = null;
        }
    }
}
