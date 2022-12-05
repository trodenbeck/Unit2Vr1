using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn_Collection : MonoBehaviour
{
    public static int AcornCount;

    void Start()
    {
        AcornCount = 0;
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            AcornCount += 1;
        }
    }
}
