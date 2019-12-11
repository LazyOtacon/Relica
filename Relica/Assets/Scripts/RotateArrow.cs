using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArrow : MonoBehaviour
{
    public Vector3 fv;
    public Rigidbody2D rBody;

    //void Start()
    //{
    //    this.transform.Rotate(new Vector3(0, 0, 360.0f - Vector3.Angle(this.transform.right, fv.normalized)));
    //}

    //void FixedUpdate()
    //{
    //    this.transform.Rotate(new Vector3(0, 0, 360.0f - Vector3.Angle(this.transform.right, this.rBody.velocity.normalized)));
    //}

        void Start()
    {
        this.transform.Rotate(new Vector3(0, 0, 360.0f - Vector3.Angle(this.transform.right, fv.normalized)));
       // transform.LookAt(transform.position - rBody.velocity);
       // transform.Rotate(90, 0, 0);
    }

    void FixedUpdate()
    {
        transform.Rotate(90, 0, 0);
        this.transform.Rotate(new Vector3(0, 0, 360.0f - Vector3.Angle(this.transform.right, this.rBody.velocity.normalized)));
    }
}
