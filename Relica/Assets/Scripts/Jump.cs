using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float fallMulti;
    public float lowfall;
    public float jumpvel;

    private Rigidbody2D rBody;


    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
     if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up* jumpvel;
    Debug.Log("JUM");
        }

        if (rBody.velocity.y< 0)
        {
            rBody.velocity += Vector2.up* Physics2D.gravity.y * (fallMulti - 1) * Time.deltaTime;
        }
        else if (rBody.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rBody.velocity += Vector2.up* Physics2D.gravity.y * (lowfall - 1) * Time.deltaTime;
        }
    }



}
