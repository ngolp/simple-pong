using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public float ballSpeed = 5;
    public Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        resetMovement();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void resetMovement()
    {
        transform.position = Vector3.zero;
        myRigidbody.velocity = Vector3.zero;

        float xDirection = 1;
        float yDirection = 0;
        if (Random.value < 0.5f)
            yDirection = Random.Range(0.5f, 1.0f);
        else
            yDirection = Random.Range(-1.0f, -0.5f);

        Vector2 direction = new Vector2(xDirection, yDirection);
        myRigidbody.velocity = ballSpeed * direction.normalized;
    }
}