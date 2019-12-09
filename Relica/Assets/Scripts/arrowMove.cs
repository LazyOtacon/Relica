using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowMove : MonoBehaviour
{

    private Rigidbody2D rBody;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
