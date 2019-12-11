using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight_Destroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        //This will be if arrow hits the knight
        if (col.gameObject.name == "INSERT NAME OF ARROW HERE")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
        //This will be if player touches the knight
        if (col.gameObject.name == "INSERT NAME OF PLAYER CHARACTER HERE")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
