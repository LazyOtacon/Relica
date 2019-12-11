using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform bow;
    public GameObject arrow;
    public float arrowSpeed = 10f;
    public float fireRate = 0.5f;
    private float counter = 0.0f;

    void Update()
    {
        counter += Time.deltaTime;

        if (Input.GetButtonDown("Fire1") && counter > fireRate)
        {
            fire();
            counter = 0.0f;
        }


    }


    void fire()
    {
        GameObject Arrow = Instantiate(arrow, bow.position, bow.rotation);
        Rigidbody2D rBody = arrow.GetComponent<Rigidbody2D>();
        rBody.AddForce(bow.up * arrowSpeed, ForceMode2D.Impulse);
    }

}
