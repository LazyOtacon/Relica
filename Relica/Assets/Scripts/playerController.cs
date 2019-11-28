using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;
    public float fallMulti;
    public float lowfall;
    public float jumpvel;

    private Rigidbody2D rBody;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;


    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius,whatIsGround);


        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
    
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpvel;

        }

        if (rBody.velocity.y < 0)
        {
            rBody.velocity += Vector2.up * Physics2D.gravity.y * (fallMulti - 1) * Time.deltaTime;
        }
        else if (rBody.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rBody.velocity += Vector2.up * Physics2D.gravity.y * (lowfall - 1) * Time.deltaTime;
        }


        rBody.velocity = new Vector2(horiz * speed, rBody.velocity.y);
    
    }
}
