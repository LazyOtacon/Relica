using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject congratulations;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Relica Game");
        }
        if (Input.GetKey(KeyCode.F))
        {
            Application.Quit();
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        //This will be if Player reaches end
        if (col.gameObject.name == "Ventus wip")
        {
            congratulations.SetActive(true);
        }
    }
}
