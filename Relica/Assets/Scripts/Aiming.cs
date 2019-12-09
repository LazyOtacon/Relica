using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{

    public Camera cam;
    public Rigidbody2D rBody;
    Vector2 mousepos;

    void Update()
    {
        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);

    }


    void FixedUpdate()
    {
        Vector2 aim = mousepos - rBody.position;
        float angle = Mathf.Atan2(aim.y,aim.x) * Mathf.Rad2Deg;
        rBody.rotation = angle;
        transform.localPosition = new Vector2(0, 0);

    }
}
