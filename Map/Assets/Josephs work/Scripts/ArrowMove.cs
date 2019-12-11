using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    private Rigidbody2D rBody;
    private GameObject player;
    public GameObject arrow;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        rBody.velocity = transform.right * 10;
        //  transform.rotation = Quaternion.LookRotation(rBody.velocity);
        player = GameObject.FindWithTag("Player");
    }


 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            // player.gameObject.transform.position =  new Vector2(arrow.gameObject.transform.position.x, arrow.gameObject.transform.position.y);
            player.transform.position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y + 1, collision.gameObject.transform.position.z);

            Destroy(gameObject);
        }

    }
}
