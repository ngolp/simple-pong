using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opponentScript : MonoBehaviour
{
    public float moveSpeed = 0.05f;
    public bool touchingTop = false;
    public bool touchingBot = false;
    public Rigidbody2D ballRB;
    public Collider2D objectCollider;
    public Collider2D otherCollider1;
    public Collider2D otherCollider2;

    // Start is called before the first frame update
    void Start()
    {
        otherCollider1 = GameObject.FindWithTag("top").GetComponent<BoxCollider2D>();
        otherCollider2 = GameObject.FindWithTag("bot").GetComponent<BoxCollider2D>();
        ballRB = GameObject.FindWithTag("ball").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yDirection = 0;
        transform.rotation = Quaternion.identity;

        if (ballRB.velocity.x > 0)
        {
            if(ballRB.transform.position.y > transform.position.y)
            {
                yDirection = 1;
            }
            else
            {
                yDirection = -1;
            }
        }
        else
        {
            if(transform.position.y > 0)
            {
                yDirection = -1;
            }
            else
            {
                yDirection = 1;
            }
        }

        if (objectCollider.IsTouching(otherCollider1))
        {
            touchingTop = true;
        }
        else if (objectCollider.IsTouching(otherCollider2))
        {
            touchingBot = true;
        }
        else
        {
            touchingTop = false;
            touchingBot = false;
        }

        if ((yDirection > 0 && !touchingTop) || (yDirection < 0 && !touchingBot))
        {
            Vector3 moveDirection = new Vector3(0.0f, yDirection * moveSpeed);

            transform.position += moveDirection;
        }
    }
}