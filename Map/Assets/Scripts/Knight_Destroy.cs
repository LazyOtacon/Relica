using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Destroy : MonoBehaviour
{
    public GameObject death;
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
            death.SetActive(true);
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
