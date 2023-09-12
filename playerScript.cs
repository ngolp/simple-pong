using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public bool touchingTop = false;
    public bool touchingBot = false;
    public Collider2D objectCollider;
    public Collider2D otherCollider1;
    public Collider2D otherCollider2;

    // Start is called before the first frame update
    void Start()
    {
        otherCollider1 = GameObject.FindWithTag("top").GetComponent<BoxCollider2D>();
        otherCollider2 = GameObject.FindWithTag("bot").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(-8.19f, transform.position.y);
        transform.rotation= Quaternion.identity;
        if (objectCollider.IsTouching(otherCollider1))
        {
            touchingTop = true;
        }
        else if(objectCollider.IsTouching(otherCollider2))
        {
            touchingBot = true;
        }
        else
        {
            touchingTop = false;
            touchingBot = false;
        }
        
        float yDirection = Input.GetAxis("Vertical");

        if((yDirection > 0 && !touchingTop) || (yDirection < 0 && !touchingBot))
        {
            Vector3 moveDirection = new Vector3(0.0f, yDirection * moveSpeed * Time.deltaTime);

            transform.position += moveDirection;
        }
    }
}