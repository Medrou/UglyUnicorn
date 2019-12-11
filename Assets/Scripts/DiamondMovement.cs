using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondMovement : MonoBehaviour
{
    public float speed; //= 1.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;


    // Start is called before the first frame update
    void Start()
    {
      int currentScore = Score.scoreValue;

        if(currentScore >= 5)
        {
            speed += 0.5f;
        }
        if (currentScore >= 10)
        {
            speed += 0.5f;
        }
        if (currentScore >= 15)
        {
            speed += 0.5f;
        }
        if (currentScore >= 20)
        {
            speed += 0.5f;
        }
        if (currentScore >= 25)
        {
            speed += 0.5f;
        }
        if (currentScore >= 30)
        {
            speed += 0.5f;
        }
        if (currentScore >= 35)
        {
            speed += 0.5f;
        }
        if (currentScore >= 40)
        {
            speed += 0.5f;
        }
        if (currentScore >= 45)
        {
            speed += 0.5f;
        }
        if (currentScore >= 50)
        {
            speed += 0.5f;
        }
        if (currentScore >= 55)
        {
            speed += 0.5f;
        }
        if (currentScore >= 60)
        {
            speed += 0.5f;
        }
        if (currentScore >= 65)
        {
            speed += 0.5f;
        }
        if (currentScore >= 70)
        {
            speed += 0.5f;
        }
        if (currentScore >= 75)
        {
            speed += 0.5f;
        }
        if (currentScore >= 80)
        {
            speed += 0.5f;
        }
        if (currentScore >= 85)
        {
            speed += 0.5f;
        }
        if (currentScore >= 90)
        {
            speed += 0.5f;
        }
        if (currentScore >= 95)
        {
            speed += 0.5f;
        }
        if (currentScore >= 100)
        {
            speed += 0.5f;
        }
        if (currentScore >= 105)
        {
            speed += 0.5f;
        }
        if (currentScore >= 110)
        {
            speed += 0.5f;
        }
        if (currentScore >= 120)
        {
            speed += 0.5f;
        }
        if (currentScore >= 125)
        {
            speed += 0.5f;
        }


        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 2);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < screenBounds.x * 2)
        {
            //Destroy(this.gameObject);
        }
        

        
        
    }
}
