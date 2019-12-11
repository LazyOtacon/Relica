﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Destroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        //This will be if arrow hits the knight
        if (col.gameObject.name == "Arrow(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
        //This will be if player touches the knight
        if (col.gameObject.name == "Ventus wip")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
