using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Pop_Up : MonoBehaviour
{
    public GameObject tutorial;
        void OnCollisionEnter2D(Collision2D col)
        {
            //This will be if Player reaches end
            if (col.gameObject.name == "Ventus wip")
            {
                tutorial.SetActive(true);
            }
        }
}
