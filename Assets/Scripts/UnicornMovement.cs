using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnicornMovement : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D myRigidbody;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D myCollider;

   public bool colliding;
    GameObject colliderobject;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

    }

    public void ButtonPress()
    {
        if (colliderobject != null)
        {
            Destroy(colliderobject);
            Score.scoreValue += 1;
        }
        

        

       }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "diamondRed")
        {
            colliding = true;
            colliderobject = other.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "diamondRed")
        {
            colliding = false;
            colliderobject = null;
        }
    }

 
}
