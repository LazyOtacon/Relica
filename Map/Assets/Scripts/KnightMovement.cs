using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMovement : MonoBehaviour
{
    public float speed = 20.0f;
    int counter = 0;

    private Rigidbody2D rBody;
    private void FixedUpdate()
    {
        if (counter >= 0 && counter < 20)
        {
            rBody = GetComponent<Rigidbody2D>();
            rBody.velocity = Vector2.right * speed;
            counter++;
        }
        if (counter == 20)
        {
            rBody = GetComponent<Rigidbody2D>();
            rBody.velocity = Vector2.right * speed;
            counter = 39;
        }
        if (counter == 21)
        {
            rBody = GetComponent<Rigidbody2D>();
            rBody.velocity = Vector2.left * speed;
            counter = 0;
        }
        if (counter <= 39 && counter > 21)
        {
            rBody = GetComponent<Rigidbody2D>();
            rBody.velocity = Vector2.left * speed;
            counter--;
        }
    }
}
