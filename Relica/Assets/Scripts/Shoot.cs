using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform bow;
    public GameObject arrow;
    public float arrowSpeed = 10f;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fire();
        }


    }


    void fire()
    {
        GameObject Arrow = Instantiate(arrow, bow.position, bow.rotation);
        Rigidbody2D rBody = arrow.GetComponent<Rigidbody2D>();
        rBody.AddForce(bow.up * arrowSpeed, ForceMode2D.Impulse);
    }

}
